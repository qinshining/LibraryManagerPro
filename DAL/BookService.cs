using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DBUtility;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BookService
    {
        /// <summary>
        /// 获取所有图书分类
        /// </summary>
        /// <returns></returns>
        public List<Category> GetAllCategories()
        {
            string sql = "SELECT CategoryId,CategoryName FROM Categories";
            SqlDataReader objReader = SqlHelper.GetReader(sql);
            List<Category> list = new List<Category>();
            while (objReader.Read())
            {
                list.Add(new Category()
                {
                    CategoryId = Convert.ToInt32(objReader["CategoryId"]),
                    CategoryName = objReader["CategoryName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }
        /// <summary>
        /// 获取所有出版社信息
        /// </summary>
        /// <returns></returns>
        public List<Publisher> GetAllPublishers()
        {
            string sql = "SELECT PublisherId,PublisherName FROM Publishers";
            SqlDataReader objReader = SqlHelper.GetReader(sql);
            List<Publisher> list = new List<Publisher>();
            while (objReader.Read())
            {
                list.Add(new Publisher()
                {
                    PublisherId = Convert.ToInt32(objReader["PublisherId"]),
                    PublisherName = objReader["PublisherName"].ToString()
                });
            }
            objReader.Close();
            return list;
        }
        /// <summary>
        /// 查询图书编号是否已经被使用
        /// </summary>
        /// <param name="barCode"></param>
        /// <returns></returns>
        public int GetCountByCode(string barCode)
        {
            string sql = "SELECT COUNT(1) FROM Books WHERE BarCode = @Barcode";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@Barcode", barCode)
            };
            return Convert.ToInt32(SqlHelper.GetSingleResult(sql, param));
        }
        /// <summary>
        /// 添加图书
        /// </summary>
        /// <param name="objBook"></param>
        /// <returns></returns>
        public int AddBook(Book objBook)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@BarCode", objBook.BarCode),
                new SqlParameter("@BookName", objBook.BookName),
                new SqlParameter("@Author", objBook.Author),
                new SqlParameter("@PublisherId", objBook.PublisherId),
                new SqlParameter("@PublishDate", objBook.PublishDate),
                new SqlParameter("@BookCategory", objBook.BookCategory),
                new SqlParameter("@UnitPrice", objBook.UnitPrice),
                new SqlParameter("@BookCount", objBook.BookCount),
                new SqlParameter("@Remainder", objBook.Remainder),
                new SqlParameter("@BookPosition", objBook.BookPosition),
                new SqlParameter("@BookImage", objBook.BookImage),
            };
            return SqlHelper.UpdateByProc("usp_AddBook", param);
        }
        /// <summary>
        /// 根据图书条码查询图书
        /// </summary>
        /// <param name="barCode"></param>
        /// <returns></returns>
        public Book GetBookByBarCode(string barCode)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT BookId, BarCode, BookName, Author, Books.PublisherId, PublisherName, PublishDate, BookCategory, CategoryName, UnitPrice, BookImage, BookCount, Remainder, BookPosition, RegTime FROM Books");
            sqlBuilder.Append(" INNER JOIN Categories ON Categories.CategoryId = Books.BookCategory");
            sqlBuilder.Append(" INNER JOIN Publishers ON Publishers.PublisherId = Books.PublisherId");
            sqlBuilder.Append(" WHERE BarCode = @Barcode");
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@BarCode", barCode)
            };
            SqlDataReader objReader = SqlHelper.GetReader(sqlBuilder.ToString(), param);
            Book objBook = null;
            if (objReader.Read())
            {
                objBook = new Book()
                {
                    BookId = Convert.ToInt32(objReader["BookId"]),
                    BarCode = objReader["BarCode"].ToString(),
                    BookName = objReader["BookName"].ToString(),
                    Author = objReader["Author"].ToString(),
                    PublisherId = Convert.ToInt32(objReader["PublisherId"]),
                    PublisherName = objReader["PublisherName"].ToString(),
                    PublishDate = Convert.ToDateTime(objReader["PublishDate"]),
                    BookCategory = Convert.ToInt32(objReader["BookCategory"]),
                    CategoryName = objReader["CategoryName"].ToString(),
                    UnitPrice = Convert.ToDecimal(objReader["UnitPrice"]),
                    BookImage = objReader["BookImage"] is DBNull ? string.Empty : objReader["BookImage"].ToString(),
                    BookCount = Convert.ToInt32(objReader["BookCount"]),
                    Remainder = Convert.ToInt32(objReader["Remainder"]),
                    BookPosition = objReader["BookPosition"].ToString(),
                    RegTime = Convert.ToDateTime(objReader["RegTime"])
                };
            }
            objReader.Close();
            return objBook;
        }
        /// <summary>
        /// 添加图书数量
        /// </summary>
        /// <param name="barCode"></param>
        /// <param name="addedCount"></param>
        /// <returns></returns>
        public int AddBookCount(string barCode, int addedCount)
        {
            string sql = "UPDATE Books SET BookCount = BookCount + @addedCount, Remainder = Remainder + @addedCount WHERE BarCode = @BarCode";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@BarCode", barCode),
                new SqlParameter("@addedCount", addedCount)
            };
            return SqlHelper.Update(sql, param);
        }
        /// <summary>
        /// 根据组合条件查询图书集合
        /// </summary>
        /// <param name="categoryId">分类编号</param>
        /// <param name="barCode">图书条码</param>
        /// <param name="bookName">图书名称（右模糊查询）</param>
        /// <returns></returns>
        public List<Book> GetBookByCombineConditions(string categoryId, string barCode, string bookName)
        {
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT BookId, BarCode, BookName, Author, Books.PublisherId, PublisherName, PublishDate, BookCategory, CategoryName, UnitPrice, BookImage, BookCount, Remainder, BookPosition, RegTime FROM Books");
            sqlBuilder.Append(" INNER JOIN Categories ON Categories.CategoryId = Books.BookCategory");
            sqlBuilder.Append(" INNER JOIN Publishers ON Publishers.PublisherId = Books.PublisherId");
            sqlBuilder.Append(" WHERE 1= 1");
            List<SqlParameter> paramList = new List<SqlParameter>();
            if (barCode != null && barCode.Length != 0)
            {
                sqlBuilder.Append(" AND BarCode = @BarCode");
                paramList.Add(new SqlParameter("@BarCode", barCode));
            }
            else
            {
                if (categoryId != null && categoryId.Length != 0 && categoryId != "-1")
                {
                    sqlBuilder.Append(" AND BookCategory = @BookCategory");
                    paramList.Add(new SqlParameter("@BookCategory", categoryId));
                }
                if (bookName != null && bookName.Length != 0)
                {
                    sqlBuilder.Append(" AND BookName LIKE @BookName");
                    paramList.Add(new SqlParameter("@BookName", bookName + "%"));
                }
            }
            SqlDataReader objReader = SqlHelper.GetReader(sqlBuilder.ToString(), paramList.ToArray());
            List<Book> bookList = new List<Book>();
            while (objReader.Read())
            {
                bookList.Add(new Book()
                {
                    BookId = Convert.ToInt32(objReader["BookId"]),
                    BarCode = objReader["BarCode"].ToString(),
                    BookName = objReader["BookName"].ToString(),
                    Author = objReader["Author"].ToString(),
                    PublisherId = Convert.ToInt32(objReader["PublisherId"]),
                    PublisherName = objReader["PublisherName"].ToString(),
                    PublishDate = Convert.ToDateTime(objReader["PublishDate"]),
                    BookCategory = Convert.ToInt32(objReader["BookCategory"]),
                    CategoryName = objReader["CategoryName"].ToString(),
                    UnitPrice = Convert.ToDecimal(objReader["UnitPrice"]),
                    BookImage = objReader["BookImage"] is DBNull ? string.Empty : objReader["BookImage"].ToString(),
                    BookCount = Convert.ToInt32(objReader["BookCount"]),
                    Remainder = Convert.ToInt32(objReader["Remainder"]),
                    BookPosition = objReader["BookPosition"].ToString(),
                    RegTime = Convert.ToDateTime(objReader["RegTime"])
                });
            }
            objReader.Close();
            return bookList;
        }
        /// <summary>
        /// 调用存储过程修改图书信息
        /// </summary>
        /// <param name="objBook"></param>
        /// <returns></returns>
        public int EditBook(Book objBook)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@BookName", objBook.BookName),
                new SqlParameter("@Author", objBook.Author),
                new SqlParameter("@PublisherId", objBook.PublisherId),
                new SqlParameter("@PublishDate", objBook.PublishDate),
                new SqlParameter("@BookCategory", objBook.BookCategory),
                new SqlParameter("@UnitPrice", objBook.UnitPrice),
                new SqlParameter("@BookImage", objBook.BookImage),
                new SqlParameter("@BookPosition", objBook.BookPosition),
                new SqlParameter("@BookId", objBook.BookId)
            };
            return SqlHelper.UpdateByProc("usp_EditBook", param);
        }
        /// <summary>
        /// 根据编号删除图书
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public int DeleteBook(string bookId)
        {
            string sql = "DELETE FROM Books WHERE BookId = @BookId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@BookId", bookId)
            };
            try
            {
                return SqlHelper.Update(sql, param);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception("该图书与其他数据存在级联关系，不能直接删除：" + ex.Message);
                }
                else
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
