using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp6.Classes
{
    class LoginUser : MainDatabase
    {
        public static bool userlogin { get; set; }
        public static string userID { get; set; }
        public static string userName { get; set; }
        public static string userRealName { get; set; }

        public static int authority { get; set; }


        public static int paragraf = 0, dilbilgisi = 0, anlatim = 0, siir = 0, divan = 0, userCount = 0;


       
        private LoginUser()
        {
            userlogin = false;
        }

        public static void exitUser()
        {
            userlogin = false;
            userID = null;
            userName = null;
            userRealName = null;
            authority = 1;
        }

    }
}
