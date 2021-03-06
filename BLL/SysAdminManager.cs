using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    public class SysAdminManager
    {
        private SysAdminService objAdminService = new SysAdminService();

        /// <summary>
        /// 管理员登录
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            return objAdminService.AdminLogin(objAdmin);
        }
        /// <summary>
        /// 修改管理员密码
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public int ModifyPwd(SysAdmin objAdmin)
        {
            return objAdminService.ModifyPwd(objAdmin);
        }
    }
}
