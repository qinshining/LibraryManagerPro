using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Models;
using DBUtility;

namespace DAL
{
    /// <summary>
    /// 借书数据访问类
    /// </summary>
    public class BorrowService
    {
        /// <summary>
        /// 获取借书总数
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public int GetBorrowedCount(string readingCard)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ReadingCard", readingCard)
            };
            return Convert.ToInt32(SqlHelper.GetSingleResultByProc("usp_QueryBorrowCount", param));
        }
        /// <summary>
        /// 获取服务器时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetServerTime()
        {
            string sql = "SELECT GETDATE()";
            return Convert.ToDateTime(SqlHelper.GetSingleResult(sql));
        }
        /// <summary>
        /// 保存借阅信息，同时更新图书可借库存
        /// </summary>
        /// <param name="objBorrowInfo">借书主表信息</param>
        /// <param name="borrowDetails">借书明细信息</param>
        /// <returns></returns>
        public bool AddBorrowInfo(BorrowInfo objBorrowInfo, List<BorrowDetail> borrowDetails)
        {
            List<string> sqlList = new List<string>();
            List<SqlParameter[]> paramList = new List<SqlParameter[]>();
            sqlList.Add("INSERT INTO BorrowInfo(BorrowId, ReaderId, AdminName_B) VALUES(@BorrowId, @ReaderId, @AdminName_B)");
            paramList.Add(new SqlParameter[]
            {
                new SqlParameter("@BorrowId", objBorrowInfo.BorrowId),
                new SqlParameter("@ReaderId", objBorrowInfo.ReaderId),
                new SqlParameter("@AdminName_B", objBorrowInfo.AdminName_B)
            });
            string detailSql = "INSERT INTO BorrowDetail (BorrowId, BookId, BorrowCount, NonReturnCount, Expire) VALUES(@BorrowId, @BookId, @BorrowCount, @NonReturnCount, @Expire)";
            string bookSql = "UPDATE Books SET Remainder = Remainder - @BorrowCount WHERE BookId = @BookId";
            foreach (BorrowDetail item in borrowDetails)
            {
                sqlList.Add(detailSql);
                paramList.Add(new SqlParameter[]
                {
                    new SqlParameter("@BorrowId", item.BorrowId),
                    new SqlParameter("@BookId", item.BookId),
                    new SqlParameter("@BorrowCount", item.BorrowCount),
                    new SqlParameter("@NonReturnCount", item.NonReturnCount),
                    new SqlParameter("@Expire", item.Expire)
                });
                sqlList.Add(bookSql);
                paramList.Add(new SqlParameter[]
                {
                    new SqlParameter("@BorrowCount", item.BorrowCount),
                    new SqlParameter("@BookId", item.BookId)
                });
            }
            return SqlHelper.UpdateByTran(sqlList, paramList);
        }
        /// <summary>
        /// 根据借阅证号查询借书记录
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public List<BorrowDetail> GetBorrowDetails(string readingCard)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ReadingCard", readingCard)
            };
            SqlDataReader objReader = SqlHelper.GetReaderByProc("usp_QueryBookByReadingCard", param);
            List<BorrowDetail> detailList = new List<BorrowDetail>();
            while (objReader.Read())
            {
                detailList.Add(new BorrowDetail()
                {
                    BorrowDetailId = Convert.ToInt32(objReader["BorrowDetailId"]),
                    BorrowId = objReader["BorrowId"].ToString(),
                    BookId = Convert.ToInt32(objReader["BookId"]),
                    BarCode = objReader["BarCode"].ToString(),
                    BookName = objReader["BookName"].ToString(),
                    BorrowDate = Convert.ToDateTime(objReader["BorrowDate"]),
                    Expire = Convert.ToDateTime(objReader["Expire"]),
                    BorrowCount = Convert.ToInt32(objReader["BorrowCount"]),
                    ReturnCount = Convert.ToInt32(objReader["ReturnCount"]),
                    NonReturnCount = Convert.ToInt32(objReader["NonReturnCount"]),
                    StatusDesc = objReader["StatusDesc"].ToString()
                });
            }
            objReader.Close();
            return detailList;
        }
        /// <summary>
        /// 调用存储过程执行还书，更新借书记录、还书记录、图书可借库存
        /// </summary>
        /// <param name="returnBookList"></param>
        /// <returns></returns>
        public bool ReturnBooks(List<ReturnBook> returnBookList)
        {
            List<SqlParameter[]> paramList = new List<SqlParameter[]>();
            foreach (ReturnBook item in returnBookList)
            {
                paramList.Add(new SqlParameter[]
                {
                    new SqlParameter("@BorrowDetailId",item.BorrowDetailId),
                    new SqlParameter("@ReturnCount",item.ReturnCount),
                    new SqlParameter("@AdminName_R",item.AdminName_R),
                    new SqlParameter("@BookId",item.BookId),
                });
            }
            return SqlHelper.UpdateByTran("usp_ReturnBook", paramList);
        }


    }
}
