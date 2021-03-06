using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using System.Data;
using System.Data.SqlClient;
using DBUtility;

namespace DAL
{
    public class ReaderService
    {
        /// <summary>
        /// 会员办证（添加读者）
        /// </summary>
        /// <param name="objReader"></param>
        /// <returns></returns>
        public int AddReader(Reader objReader)
        {
            string sql = "INSERT INTO Readers (ReadingCard, ReaderName, Gender, IDCard, ReaderAddress, PostCode, PhoneNumber, RoleId, ReaderImage, ReaderPwd, AdminId) VALUES (@ReadingCard, @ReaderName, @Gender, @IDCard, @ReaderAddress, @PostCode, @PhoneNumber, @RoleId, @ReaderImage, @ReaderPwd, @AdminId)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ReadingCard", objReader.ReadingCard),
                new SqlParameter("@ReaderName", objReader.ReaderName),
                new SqlParameter("@Gender", objReader.Gender),
                new SqlParameter("@IDCard", objReader.IDCard),
                new SqlParameter("@ReaderAddress", objReader.ReaderAddress),
                new SqlParameter("@PostCode", objReader.PostCode),
                new SqlParameter("@PhoneNumber", objReader.PhoneNumber),
                new SqlParameter("@RoleId", objReader.RoleId),
                new SqlParameter("@ReaderImage", objReader.ReaderImage),
                new SqlParameter("@ReaderPwd", objReader.ReaderPwd),
                new SqlParameter("@AdminId", objReader.AdminId),
            };
            return SqlHelper.Update(sql, param);
        }
        /// <summary>
        /// 修改读者信息
        /// </summary>
        /// <param name="objReader"></param>
        /// <returns></returns>
        public int EditReader(Reader objReader)
        {
            string sql = "UPDATE Readers SET ReaderName = @ReaderName, Gender = @Gender, IDCard = @IDCard, ReaderAddress = @ReaderAddress, PostCode = @PostCode, PhoneNumber = @PhoneNumber, RoleId = @RoleId, ReaderImage = @ReaderImage WHERE ReaderId = @ReaderId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ReaderName", objReader.ReaderName),
                new SqlParameter("@Gender", objReader.Gender),
                new SqlParameter("@IDCard", objReader.IDCard),
                new SqlParameter("@ReaderAddress", objReader.ReaderAddress),
                new SqlParameter("@PostCode", objReader.PostCode),
                new SqlParameter("@PhoneNumber", objReader.PhoneNumber),
                new SqlParameter("@RoleId", objReader.RoleId),
                new SqlParameter("@ReaderImage", objReader.ReaderImage),
                new SqlParameter("@ReaderId", objReader.ReaderId),
            };
            return SqlHelper.Update(sql, param);
        }
        /// <summary>
        /// 改变借阅证状态
        /// </summary>
        /// <param name="statusId"></param>
        /// <param name="readerId"></param>
        /// <returns></returns>
        public int ChangeReaderCardStatus(string statusId, string readerId)
        {
            string sql = "UPDATE Readers SET StatusId = @StatusId WHERE ReaderId = @ReaderId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@StatusId", statusId),
                new SqlParameter("@ReaderId", readerId)
            };
            return SqlHelper.Update(sql, param);
        }
        /// <summary>
        /// 查询借阅证号是否重复
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public int GetCountByReadingCard(string readingCard)
        {
            string sql = "SELECT COUNT(1) FROM Readers WHERE ReadingCard = @ReadingCard";
            return Convert.ToInt32(SqlHelper.GetSingleResult(sql, new SqlParameter[] { new SqlParameter("@ReadingCard", readingCard) }));
        }
        /// <summary>
        /// 查询借阅证号是否重复
        /// </summary>
        /// <param name="readingCard"></param>
        /// <param name="readerId"></param>
        /// <returns></returns>
        public int GetCountByReadingCard(string readingCard, string readerId)
        {
            string sql = "SELECT COUNT(1) FROM Readers WHERE ReadingCard = @ReadingCard AND ReaderId <> @ReaderId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ReadingCard", readingCard),
                new SqlParameter("@ReaderId", readerId)
            };
            return Convert.ToInt32(SqlHelper.GetSingleResult(sql, param));
        }
        /// <summary>
        /// 查询身份证号是否重复
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public int GetCountByIDCard(string idCard)
        {
            string sql = "SELECT COUNT(1) FROM Readers WHERE IDCard = @IDCard";
            return Convert.ToInt32(SqlHelper.GetSingleResult(sql, new SqlParameter[] { new SqlParameter("@IDCard", idCard) }));
        }
        /// <summary>
        /// 查询借阅证号是否重复
        /// </summary>
        /// <param name="readingCard"></param>
        /// <param name="readerId"></param>
        /// <returns></returns>
        public int GetCountByIDCard(string idCard, string readerId)
        {
            string sql = "SELECT COUNT(1) FROM Readers WHERE IDCard = @IDCard AND ReaderId <> @ReaderId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@IDCard", idCard),
                new SqlParameter("@ReaderId", readerId)
            };
            return Convert.ToInt32(SqlHelper.GetSingleResult(sql, param));
        }
        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetRoles()
        {
            string sql = "SELECT RoleId,RoleName FROM ReaderRoles";
            return SqlHelper.GetDataSet(sql).Tables[0];
        }
        /// <summary>
        /// 根据借阅证编号查询读者
        /// </summary>
        /// <param name="readingCard"></param>
        /// <returns></returns>
        public Reader GetReaderByReadingCard(string readingCard)
        {
            string whereSql = " WHERE ReadingCard = @ReadingCard";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@ReadingCard", readingCard)
            };
            return GetReader(whereSql, param);
        }
        /// <summary>
        /// 根据身份证号查询读者
        /// </summary>
        /// <param name="idCard"></param>
        /// <returns></returns>
        public Reader GetReaderByIDCard(string idCard)
        {
            string whereSql = " WHERE IDCard = @IDCard";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@IDCard", idCard)
            };
            return GetReader(whereSql, param);
        }
        //根据sql语句查询读者对象
        private Reader GetReader(string whereSql, SqlParameter[] param)
        {
            string sql = "SELECT ReaderId,ReadingCard,ReaderName,Gender,IDCard,ReaderAddress,PostCode,PhoneNumber,ReaderImage,RegTime,StatusId,Readers.RoleId,RoleName,AllowDay,AllowCounts FROM Readers INNER JOIN ReaderRoles ON ReaderRoles.RoleId = Readers.RoleId ";
            sql += whereSql;
            SqlDataReader reader = SqlHelper.GetReader(sql, param);
            Reader objReader = null;
            if (reader.Read())
            {
                objReader = new Reader()
                {
                    ReaderId = Convert.ToInt32(reader["ReaderId"]),
                    ReadingCard = reader["ReadingCard"].ToString(),
                    ReaderName = reader["ReaderName"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    IDCard = reader["IDCard"].ToString(),
                    ReaderAddress = reader["ReaderAddress"].ToString(),
                    PostCode = reader["PostCode"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    ReaderImage = reader["ReaderImage"].ToString(),
                    RegTime = Convert.ToDateTime(reader["RegTime"]),
                    StatusId = Convert.ToInt32(reader["StatusId"]),
                    RoleId = Convert.ToInt32(reader["RoleId"]),
                    RoleName = reader["RoleName"].ToString(),
                    AllowDay = Convert.ToInt32(reader["AllowDay"]),
                    AllowCounts = Convert.ToInt32(reader["AllowCounts"])
                };
            }
            reader.Close();
            return objReader;
        }
        /// <summary>
        /// 根据角色查询读者列表、该角色读者总数（弃用）
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="readerCount"></param>
        /// <returns></returns>
        public List<Reader> GetReaders(string roleId, out int readerCount)
        {
            StringBuilder sqlBuilder1 = new StringBuilder();
            sqlBuilder1.Append("SELECT ReaderId,ReadingCard,ReaderName,Gender,IDCard,ReaderAddress,PostCode,PhoneNumber,ReaderImage,RegTime,StatusId,Readers.RoleId,RoleName FROM Readers INNER JOIN ReaderRoles ON ReaderRoles.RoleId = Readers.RoleId");
            StringBuilder sqlBuilder2 = new StringBuilder();
            sqlBuilder2.Append("SELECT ReaderCount = COUNT(1) FROM Readers");
            List<SqlParameter> paramList = new List<SqlParameter>();
            if (roleId != "-1")
            {
                string sqlWhere = " WHERE Readers.RoleId = @RoleId";
                sqlBuilder1.Append(sqlWhere);
                sqlBuilder2.Append(sqlWhere);
                paramList.Add(new SqlParameter("@RoleId", roleId));
            }
            string sql = sqlBuilder1.ToString() + ";" + sqlBuilder2.ToString();
            SqlDataReader reader = SqlHelper.GetReader(sql, paramList.ToArray());
            List<Reader> readerList = new List<Reader>();
            while (reader.Read())
            {
                readerList.Add(new Reader()
                {
                    ReaderId = Convert.ToInt32(reader["ReaderId"]),
                    ReadingCard = reader["ReadingCard"].ToString(),
                    ReaderName = reader["ReaderName"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    IDCard = reader["IDCard"].ToString(),
                    ReaderAddress = reader["ReaderAddress"].ToString(),
                    PostCode = reader["PostCode"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    ReaderImage = reader["ReaderImage"].ToString(),
                    RegTime = Convert.ToDateTime(reader["RegTime"]),
                    StatusId = Convert.ToInt32(reader["StatusId"]),
                    RoleId = Convert.ToInt32(reader["RoleId"]),
                    RoleName = reader["RoleName"].ToString()
                });
            }
            if (reader.NextResult())
            {
                if (reader.Read())
                {
                    readerCount = Convert.ToInt32(reader["ReaderCount"]);
                }
                else
                {
                    readerCount = 0;
                }
            }
            else
            {
                readerCount = 0;
            }
            reader.Close();
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
            StringBuilder sqlBuilder = new StringBuilder();
            sqlBuilder.Append("SELECT ReaderId,ReadingCard,ReaderName,Gender,IDCard,ReaderAddress,PostCode,PhoneNumber,ReaderImage,RegTime,StatusId,Readers.RoleId,RoleName FROM Readers INNER JOIN ReaderRoles ON ReaderRoles.RoleId = Readers.RoleId");
            List<SqlParameter> paramList = new List<SqlParameter>();
            if (roleId != "-1")
            {
                string sqlWhere = " WHERE Readers.RoleId = @RoleId";
                sqlBuilder.Append(sqlWhere);
                paramList.Add(new SqlParameter("@RoleId", roleId));
            }
            SqlDataReader reader = SqlHelper.GetReader(sqlBuilder.ToString(), paramList.ToArray());
            List<Reader> readerList = new List<Reader>();
            while (reader.Read())
            {
                readerList.Add(new Reader()
                {
                    ReaderId = Convert.ToInt32(reader["ReaderId"]),
                    ReadingCard = reader["ReadingCard"].ToString(),
                    ReaderName = reader["ReaderName"].ToString(),
                    Gender = reader["Gender"].ToString(),
                    IDCard = reader["IDCard"].ToString(),
                    ReaderAddress = reader["ReaderAddress"].ToString(),
                    PostCode = reader["PostCode"].ToString(),
                    PhoneNumber = reader["PhoneNumber"].ToString(),
                    ReaderImage = reader["ReaderImage"].ToString(),
                    RegTime = Convert.ToDateTime(reader["RegTime"]),
                    StatusId = Convert.ToInt32(reader["StatusId"]),
                    RoleId = Convert.ToInt32(reader["RoleId"]),
                    RoleName = reader["RoleName"].ToString()
                });
            }
            reader.Close();
            return readerList;
        }
    }
}
