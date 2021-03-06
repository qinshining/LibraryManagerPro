using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    public class BorrowManager
    {
        private BorrowService objBorrowService = new BorrowService();

        /// <summary>
        /// 获取借书总数
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public int GetBorrowedCount(string readingCard)
        {
            return objBorrowService.GetBorrowedCount(readingCard);
        }
        /// <summary>
        /// 获取服务器时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetServerTime()
        {
            return objBorrowService.GetServerTime();
        }
        /// <summary>
        /// 保存借阅信息，同时更新图书可借库存
        /// </summary>
        /// <param name="objBorrowInfo">借书主表信息</param>
        /// <param name="borrowDetails">借书明细信息</param>
        /// <returns></returns>
        public bool AddBorrowInfo(BorrowInfo objBorrowInfo, List<BorrowDetail> borrowDetails)
        {
            return objBorrowService.AddBorrowInfo(objBorrowInfo, borrowDetails);
        }
        /// <summary>
        /// 根据借阅证号查询借书记录
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public List<BorrowDetail> GetBorrowDetails(string readingCard)
        {
            return objBorrowService.GetBorrowDetails(readingCard);
        }
        /// <summary>
        /// 执行还书操作，更新借书记录、还书记录、图书可借库存
        /// </summary>
        /// <param name="returnList">还书记录</param>
        /// <param name="borrowList">借书记录</param>
        /// <param name="adminName">管理员姓名</param>
        /// <returns></returns>
        public bool ReturnBooks(List<BorrowDetail> returnList, List<BorrowDetail> borrowList, string adminName)
        {
            List<ReturnBook> returnBookList = new List<ReturnBook>();
            foreach (BorrowDetail returnItem in returnList)
            {
                int returnCount = returnItem.ReturnCount;
                List<BorrowDetail> curBorrowDetails = (from b in borrowList where b.BarCode == returnItem.BarCode select b).ToList<BorrowDetail>();
                curBorrowDetails.Sort(new BorrowOrderByExpireASC());//排序，到期时间早的先还
                foreach (BorrowDetail borrowItem in curBorrowDetails)
                {
                    if (borrowItem.NonReturnCount >= returnCount)
                    {
                        returnBookList.Add(new ReturnBook()
                        {
                            BorrowDetailId = borrowItem.BorrowDetailId,
                            ReturnCount = returnCount,
                            AdminName_R = adminName,
                            BookId = borrowItem.BookId
                        });
                        break;
                    }
                    else
                    {
                        returnBookList.Add(new ReturnBook()
                        {
                            BorrowDetailId = borrowItem.BorrowDetailId,
                            ReturnCount = borrowItem.NonReturnCount,
                            AdminName_R = adminName,
                            BookId = borrowItem.BookId
                        });
                        returnCount -= borrowItem.NonReturnCount;
                    }
                }
            }
            return objBorrowService.ReturnBooks(returnBookList);
        }
    }
    /// <summary>
    /// 借书记录排序类（按到期日期升序）
    /// </summary>
    public class BorrowOrderByExpireASC : IComparer<BorrowDetail>
    {
        public int Compare(BorrowDetail x, BorrowDetail y)
        {
            return x.Expire.CompareTo(y.Expire);
        }
    }
}
