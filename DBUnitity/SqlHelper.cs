using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Common;

namespace DBUtility
{
    public class SqlHelper
    {
        private static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        #region 执行格式化sql语句

        /// <summary>
        /// 执行增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string errorInfo = "Update(string sql)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 查询单一结果
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                string errorInfo = "GetSingleResult(string sql)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行查询，返回reader对象
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Close();
                string errorInfo = "GetReader(string sql)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
        }
        /// <summary>
        /// 执行查询，返回dataset数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                string errorInfo = "GetDataSet(string sql)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 启用事务，执行多条sql语句
        /// </summary>
        /// <param name="sqlList"></param>
        /// <returns></returns>
        public bool UpdateByTran(List<string> sqlList)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();
                foreach (string sql in sqlList)
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();
                }
                string errorInfo = "UpdateByTran(List<string> sqlList)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }
                conn.Close();
            }
        }

        #endregion

        #region 执行带参数的sql语句

        /// <summary>
        /// 执行增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int Update(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(param);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string errorInfo = "Update(string sql, SqlParameter[] param)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 查询单一结果
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(param);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                string errorInfo = "GetSingleResult(string sql, SqlParameter[] param)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行查询，返回reader对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(param);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Close();
                string errorInfo = "GetReader(string sql, SqlParameter[] param))发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
        }
        /// <summary>
        /// 执行插入主表和明细表操作（适用场景：主表单条sql，明细表sql样式一致，只是参数不同）
        /// </summary>
        /// <param name="mainSql">主表sql</param>
        /// <param name="mainParam">主表参数</param>
        /// <param name="detailSql">明细表sql</param>
        /// <param name="detailParam">明细表参数</param>
        /// <returns></returns>
        public static bool UpdateByTran(string mainSql, SqlParameter[] mainParam, string detailSql, List<SqlParameter[]> detailParam)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = mainSql;
            if (mainParam != null && mainParam.Length != 0)
            {
                cmd.Parameters.AddRange(mainParam);
            }
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                cmd.CommandText = detailSql;
                foreach (SqlParameter[] param in detailParam)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(param);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();
                }
                string errorInfo = "UpdateByTran(string mainSql, SqlParameter[] mainParam, string detailSql, List<SqlParameter[]> detailParam)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }
                conn.Close();
            }
        }
        /// <summary>
        /// 通过事务执行多条sql语句，sql语句和参数必须一一对应
        /// </summary>
        /// <param name="sqlList"></param>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public static bool UpdateByTran(List<string> sqlList, List<SqlParameter[]> paramList)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();
                for (int i = 0; i < sqlList.Count; i++)
                {
                    cmd.CommandText = sqlList[i];
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(paramList[i]);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();
                }
                string errorInfo = "UpdateByTran(List<string> sqlList, List<SqlParameter[]> paramList)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }
                conn.Close();
            }
        }

        #endregion

        #region 执行存储过程

        /// <summary>
        /// 执行增删改操作
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int UpdateByProc(string procName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(param);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string errorInfo = "UpdateByProc(string procName, SqlParameter[] param)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 查询单一结果
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object GetSingleResultByProc(string procName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(param);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                string errorInfo = "GetSingleResultByProc(string procName, SqlParameter[] param)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                conn.Close();
            }
        }
        /// <summary>
        /// 执行查询，返回reader对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static SqlDataReader GetReaderByProc(string procName, SqlParameter[] param)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(param);
            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Close();
                string errorInfo = "GetReaderByProc(string procName, SqlParameter[] param)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
        }
        /// <summary>
        /// 基于事务执行存储过程
        /// </summary>
        /// <param name="procedureName">存储过程名称</param>
        /// <param name="paramList">参数集合</param>
        /// <returns></returns>
        public static bool UpdateByTran(string procedureName, List<SqlParameter[]> paramList)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                cmd.Transaction = conn.BeginTransaction();
                foreach (SqlParameter[] item in paramList)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(item);
                    cmd.ExecuteNonQuery();
                }
                cmd.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction.Rollback();
                }
                string errorInfo = "UpdateByTran(string procedureName, List<SqlParameter[]> paramList)发生异常：" + ex.Message;
                LogUnitity.WriteLog("DBError.log", errorInfo);
                throw new Exception(errorInfo);
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }
                conn.Close();
            }
        }

        #endregion

    }
}
