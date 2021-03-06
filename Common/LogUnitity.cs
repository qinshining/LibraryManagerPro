using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Common
{
    public class LogUnitity
    {
        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="fileName">日志名</param>
        /// <param name="content">日志内容</param>
        public static void WriteLog(string fileName, string content)
        {
            FileStream fs = new FileStream(fileName, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string newContent = "【" + DateTime.Now.ToString() + "】" + content;
            sw.WriteLine(newContent);
            sw.Close();
            fs.Close();
        }
    }
}
