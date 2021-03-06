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
    public class SysAdminService
    {
        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            string sql = "SELECT AdminName,StatusId,RoleId FROM SysAdmins WHERE AdminId = @AdminId AND LoginPwd = @LoginPwd";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@AdminId", objAdmin.AdminId),
                new SqlParameter("@LoginPwd", objAdmin.LoginPwd)
            };
            SqlDataReader objReader = SqlHelper.GetReader(sql, param);
            if (objReader.Read())
            {
                objAdmin.AdminName = objReader["AdminName"].ToString();
                objAdmin.StatusId = Convert.ToInt32(objReader["StatusId"]);
                objAdmin.RoleId = Convert.ToInt32(objReader["RoleId"]);
            }
            else
            {
                objAdmin = null;
            }
            objReader.Close();
            return objAdmin;
        }
        /// <summary>
        /// 修改管理员密码
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public int ModifyPwd(SysAdmin objAdmin)
        {
            string sql = "UPDATE SysAdmins SET LoginPwd = @LoginPwd WHERE  AdminId = @AdminId";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@LoginPwd", objAdmin.LoginPwd),
                new SqlParameter("@AdminId", objAdmin.AdminId)
            };
            return SqlHelper.Update(sql, param);
        }
    }
}
