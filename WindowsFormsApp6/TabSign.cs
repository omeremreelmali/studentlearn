using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class TabSign : UserControl
    {
        public TabSign()
        {
            InitializeComponent();
        }

        bool userNameValidation = true, passwordValidation = true;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Classes.Crud lgn = new Classes.Crud();
            if (userNameValidation && passwordValidation)
            {
                string[] user = lgn.userLogin(userNameText.Text, passText.Text);
                if (user == null)
                {
                    MessageBox.Show("Kullanıcı Bulunamadı");
                }
                else if (user[0] == "PAROLA_HATASI")
                {
                    MessageBox.Show("Parolanızı yanlış girdiniz.");
                }
                else
                {
                    Classes.LoginUser.userlogin = true;
                    Classes.LoginUser.userID = user[0];
                    Classes.LoginUser.userRealName = user[1];
                    Classes.LoginUser.userName = user[2];
                    Classes.LoginUser.authority = Convert.ToInt32(user[3]);
                }
            }
            else
            {
                MessageBox.Show("Hatalı kısımları düzeltin");
            }
            
            

            

        }

        
        private void PassText_OnValueChanged(object sender, EventArgs e)
        {
            if (passText.Text.Length > 15)
            {
                passwordProvider.SetError(passText, "Şifreniz 15 karakterden büyük olamaz");
                passwordValidation = false;
                
            }
            else if (passText.Text.Length < 3)
            {
                passwordProvider.SetError(passText, "Şifreniz 3 karakterden küçük olamaz");
                passwordValidation = false;
            }
            else
            {
                passwordValidation = true;
                passwordProvider.Clear();
            }
        }

        private void TabSign_Load(object sender, EventArgs e)
        {
            userNameText.Text = "ogr";
            passText.Text = "demo123";
        }

        private void TabSignUpPageButton_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("TabSignUp");
        }

     

        private void userNameText_OnValueChanged(object sender, EventArgs e)
        {
            if (userNameText.Text.Length > 20)
            {
                usernameProvider.SetError(userNameText, "Kullanıcı adınız 20 karakterden büyük olamaz");
                userNameValidation = false;
            }
            else if (userNameText.Text.Length < 3)
            {
                usernameProvider.SetError(userNameText, "Kullanıcı adınız 3 karakterden küçük olamaz");
                userNameValidation = false;
            }
            else
            {
                userNameValidation = true;
                usernameProvider.Clear();
            }
        }

    }
}
