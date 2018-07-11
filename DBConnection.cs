using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASP
{
    class DBConnection
    {
        private static string conStr = "datasource=localhost;port=3306;database=khsmmci;" +
            "username=root;password=;SslMode=none";
        public static string Constr
        {
            get
            {
                return conStr;
            }
        }
    }
}
