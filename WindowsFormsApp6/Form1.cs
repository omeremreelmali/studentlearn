using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        static Form1 _obj;

        public static Form1 Instance
        {

            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelMain; }
            set { panelMain = null; }
        }

        public Form1()
        {    
            InitializeComponent();
        }
        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton2_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void BunifuImageButton3_MouseEnter(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

       

       

        private void BunifuImageButton2_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void BunifuImageButton3_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

     
       

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
            exitButton.Visible = false;
            Classes.Tools.pageDirects("TabSign");
            loginTimer.Start();

        }

        private void MainBaseButton_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("MainBase");
        }

        private void TabSignUpButton_Click(object sender, EventArgs e)
        {
             Classes.Tools.pageDirects("TabSignUp");
        }

    
       

       

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            if (Classes.LoginUser.userID == null)
            {
                bunifuGradientPanel2.Visible = false;
            }
            else
            {
                bunifuGradientPanel2.Visible = true;
                buttonLocation();
                exitButton.Visible = true;
                loginTimer.Stop();
            }
        }

       

        private void BunifuImageButton2_MouseEnter_1(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void BunifuImageButton2_MouseLeave_1(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void QuizOpPageButton_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("QuestionOp");
        }

        private void quizPageButton_Click(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("QuizPage");
        }

       

       

        void buttonLocation()
        {
           if(Classes.LoginUser.authority == 1)
            {
                Classes.Tools.pageDirects("Statistics");
                statisticPageButton.Visible = true;
                quizPageButton.Visible = true;
                QuizOpPageButton.Visible=false;
            }
            else
            {
                statisticPageButton.Visible = true;
                quizPageButton.Visible = false;
                QuizOpPageButton.Visible = true;
                QuizOpPageButton.Location = new Point(16, 93);
                panel2.Location = new Point(5, 93);
                if (Classes.LoginUser.authority == 0) { Classes.Tools.pageDirects("adminPage"); }
                else { Classes.Tools.pageDirects("QuestionOp"); }
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Classes.LoginUser.exitUser();
            bunifuGradientPanel2.Visible = false;
            Classes.Tools.pageDirects("TabSign");
            loginTimer.Start();
            exitButton.Visible = false;
        }

        private void statisticPageButton_Click_1(object sender, EventArgs e)
        {
            Classes.Tools.pageDirects("Statistics");
        }
    }
 }

