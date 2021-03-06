using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class SysAdmin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string LoginPwd { get; set; }
        public int StatusId { get; set; }
        public int RoleId { get; set; }
    }
}
