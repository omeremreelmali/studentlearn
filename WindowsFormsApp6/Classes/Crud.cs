using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySql.Data.Entity;

namespace WindowsFormsApp6.Classes
{
    class Crud: MainDatabase
    {

        /* Öğrenci, Öğretmen ve Admin Girişi */
        public string[] userLogin(string userName, string pass)
        {

            string[] userData = new string[4];
            try
            {
                Tools appTool = new Tools();
                pass = appTool.MD5Convert(pass);
                int userLoginCount = 0;


                int id = Convert.ToInt32(LoginUser.userID);
                using (studentlearnEntities1 db = new studentlearnEntities1())
                {
                    user loginCommand = (from item in db.users
                                     where item.username == userName
                                     select item).FirstOrDefault();
                    if (loginCommand != null)
                    {
                        if (loginCommand.pass == pass)
                        {

                            userData[0] = loginCommand.id.ToString();
                            userData[1] = loginCommand.name;
                            userData[2] = loginCommand.username;
                            userData[3] = loginCommand.authority.ToString();
                        }
                        else
                        {
                            userData[0] = "PAROLA_HATASI";
                        }
                        userLoginCount++;
                    }
                }
                
                if (userLoginCount != 1)
                {
                    userData = null;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi.");
            }

            return userData;
        }

        

    }
}
