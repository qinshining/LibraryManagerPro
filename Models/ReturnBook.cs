using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class ReturnBook
    {
        public int ReturnId { get; set; }
        public int BorrowDetailId { get; set; }
        public int ReturnCount { get; set; }
        public DateTime ReturnDate { get; set; }
        public string AdminName_R { get; set; }
        //扩展属性
        public int BookId { get; set; }
    }
}
