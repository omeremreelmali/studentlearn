using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp6.Classes
{
    class Tools : MainDatabase
    {
        private static string encryption(string pass, HashAlgorithm alg)
        {
            byte[] byteValue = System.Text.Encoding.UTF8.GetBytes(pass);
            byte[] passByte = alg.ComputeHash(byteValue);
            return Convert.ToBase64String(passByte);
        }
        public string MD5Convert(string pass)
        {
            MD5CryptoServiceProvider pwd = new MD5CryptoServiceProvider();
            return encryption(pass, pwd);
        }
        public int userGetID(string userName)
        {
            int userID = 0;
            try
            {
                mainConnect();
                MySqlCommand userIDCommand = new MySqlCommand("SELECT id from users WHERE username='" + userName + "' ", mainDatabeseConn);
                MySqlDataReader reader = userIDCommand.ExecuteReader();
                reader.Read();
                userID = reader.GetInt32("id");
                mainConnect();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi.");
                mainConnect();
            }
            
            return userID;
        }
        public string userGetUserName(string id)
        {
            string userName = null;

            try
            {
                mainConnect();
                MySqlCommand userIDCommand = new MySqlCommand("SELECT username from users WHERE id='" + id + "' ", mainDatabeseConn);
                MySqlDataReader reader = userIDCommand.ExecuteReader();
                reader.Read();
                userName = reader.GetString("username").ToString();
                mainConnect();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi.");
                mainConnect();
            }

            
            return userName;
        }

        public static void pageDirects(string page)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey(page))
            {
                Form1.Instance.PnlContainer.Controls.Clear();
                if ("QuestionOp"==page)
                {
                    QuestionOp aw = new QuestionOp();
                    aw.Dock = DockStyle.Fill;
                    Form1.Instance.PnlContainer.Controls.Add(aw);
                }
                if ("MainBase" == page)
                {
                    MainBase mb = new MainBase();
                    mb.Dock = DockStyle.Fill;
                    Form1.Instance.PnlContainer.Controls.Add(mb);
                }
                
               
                
                if ("TabSign" == page)
                {
                    TabSign si = new TabSign();
                    si.Dock = DockStyle.Fill;
                    Form1.Instance.PnlContainer.Controls.Add(si);
                }
                if ("QuizPage" == page)
                {
                    QuizPage qp = new QuizPage();
                    qp.Dock = DockStyle.Fill;
                    Form1.Instance.PnlContainer.Controls.Add(qp);
                }
                if ("Statistics" == page)
                {
                    Statistics st = new Statistics();
                    st.Dock = DockStyle.Fill;
                    Form1.Instance.PnlContainer.Controls.Add(st);
                }
                if ("adminPage" == page)
                {
                    adminPage ap = new adminPage();
                    ap.Dock = DockStyle.Fill;
                    Form1.Instance.PnlContainer.Controls.Add(ap);
                }

            }
            
            Form1.Instance.PnlContainer.Controls[page].BringToFront();
        }
    }
}
