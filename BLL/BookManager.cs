using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    public class BookManager
    {
        private BookService objBookService = new BookService();

        /// <summary>
        /// 获取所有图书分类
        /// </summary>
        /// <returns></returns>
        public List<Category> GetAllCategories()
        {
            return objBookService.GetAllCategories();
        }
        /// <summary>
        /// 获取所有出版社信息
        /// </summary>
        /// <returns></returns>
        public List<Publisher> GetAllPublishers()
        {
            return objBookService.GetAllPublishers();
        }
        /// <summary>
        /// 查询图书编号是否已经被使用
        /// </summary>
        /// <param name="barCode"></param>
        /// <returns>true：编号已被使用；false：编号未被使用</returns>
        public bool GetCountByCode(string barCode)
        {
            return objBookService.GetCountByCode(barCode) > 0;
        }
        /// <summary>
        /// 添加图书
        /// </summary>
        /// <param name="objBook"></param>
        /// <returns>true：添加成功：false：添加失败</returns>
        public bool AddBook(Book objBook)
        {
            return objBookService.AddBook(objBook) == 1;
        }
        /// <summary>
        /// 根据图书条码查询图书
        /// </summary>
        /// <param name="barCode"></param>
        /// <returns></returns>
        public Book GetBookByBarCode(string barCode)
        {
            return objBookService.GetBookByBarCode(barCode);
        }
        /// <summary>
        /// 添加图书数量
        /// </summary>
        /// <param name="barCode"></param>
        /// <param name="addedCount"></param>
        /// <returns></returns>
        public int AddBookCount(string barCode, int addedCount)
        {
            return objBookService.AddBookCount(barCode, addedCount);
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
            return objBookService.GetBookByCombineConditions(categoryId, barCode, bookName);
        }
        /// <summary>
        /// 调用存储过程修改图书信息
        /// </summary>
        /// <param name="objBook"></param>
        /// <returns></returns>
        public int EditBook(Book objBook)
        {
            return objBookService.EditBook(objBook);
        }
        /// <summary>
        /// 根据编号删除图书
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        public int DeleteBook(string bookId)
        {
            return objBookService.DeleteBook(bookId);
        }
    }
}
