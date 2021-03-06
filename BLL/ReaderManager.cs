using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class ReaderManager
    {
        private ReaderService objReaderService = new ReaderService();

        /// <summary>
        /// 会员办证（添加读者）
        /// </summary>
        /// <param name="objReader"></param>
        /// <returns></returns>
        public int AddReader(Reader objReader)
        {
            return objReaderService.AddReader(objReader);
        }
        /// <summary>
        /// 修改读者信息
        /// </summary>
        /// <param name="objReader"></param>
        /// <returns></returns>
        public int EditReader(Reader objReader)
        {
            return objReaderService.EditReader(objReader);
        }
        /// <summary>
        /// 改变借阅证状态
        /// </summary>
        /// <param name="statusId">1：启用；2：禁用</param>
        /// <param name="readerId"></param>
        /// <returns></returns>
        public int ChangeReaderCardStatus(string statusId, string readerId)
        {
            return objReaderService.ChangeReaderCardStatus(statusId, readerId);
        }
        /// <summary>
        /// 查询借阅证号是否重复
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public bool IsExistsReadingCard(string readingCard)
        {
            return objReaderService.GetCountByReadingCard(readingCard) > 0;
        }
        /// <summary>
        /// 查询借阅证号是否重复
        /// </summary>
        /// <param name="readingCard"></param>
        /// <param name="readerId"></param>
        /// <returns></returns>
        public bool IsExistsReadingCard(string readingCard, string readerId)
        {
            return objReaderService.GetCountByReadingCard(readingCard, readerId) > 0;
        }
        /// <summary>
        /// 查询身份证号是否重复
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public bool IsExistsIDCard(string idCard)
        {
            return objReaderService.GetCountByIDCard(idCard) > 0;
        }
        /// <summary>
        /// 查询借阅证号是否重复
        /// </summary>
        /// <param name="readingCard"></param>
        /// <param name="readerId"></param>
        /// <returns></returns>
        public bool IsExistsIDCard(string idCard, string readerId)
        {
            return objReaderService.GetCountByIDCard(idCard, readerId) > 0;
        }
        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetRoles()
        {
            return objReaderService.GetRoles();
        }
        /// <summary>
        /// 根据借阅证编号查询读者
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public Reader GetReaderByReadingCard(string readingCard)
        {
            return objReaderService.GetReaderByReadingCard(readingCard);
        }
        /// <summary>
        /// 根据身份证号查询读者
        /// </summary>
        /// <param name="idCard"></param>
        /// <returns></returns>
        public Reader GetReaderByIDCard(string idCard)
        {
            return objReaderService.GetReaderByIDCard(idCard);
        }
        /// <summary>
        /// 根据角色查询读者列表、该角色读者总数（弃用）
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="readerCount"></param>
        /// <returns></returns>
        public List<Reader> GetReaders(string roleId, out int readerCount)
        {
            List<Reader> readerList = objReaderService.GetReaders(roleId, out readerCount);
            for (int i = 0; i < readerList.Count; i++)
            {
                switch (readerList[i].StatusId)
                {
                    case 1:
                        readerList[i].StatusDes = "正常";
                        break;
                    case 2:
                        readerList[i].StatusDes = "禁用";
                        break;
                }
            }
            return readerList;
        }
        /// <summary>
        /// 根据角色查询读者列表、该角色读者总数
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="readerCount"></param>
        /// <returns></returns>
        public List<Reader> GetReaders(string roleId)
        {
            List<Reader> readerList = objReaderService.GetReaders(roleId);
            for (int i = 0; i < readerList.Count; i++)
            {
                switch (readerList[i].StatusId)
                {
                    case 1:
                        readerList[i].StatusDes = "正常";
                        break;
                    case 2:
                        readerList[i].StatusDes = "禁用";
                        break;
                }
            }
            return readerList;
        }
    }
}
