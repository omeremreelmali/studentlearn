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
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
        }

        Classes.StatisticsOperation statisticsOP = new Classes.StatisticsOperation();


        int[] genSub; int studentID = 0;
        private void Statistics_Load(object sender, EventArgs e)
        {
            if (Classes.LoginUser.authority == 1)
            {
                studentID = Convert.ToInt32(Classes.LoginUser.userID);
            }
            else
            {
                studentList();
                studentCombobox.SelectedIndex = 0;
                studentID = (int)studentCombobox.SelectedValue;
                studentCombobox.Visible = true;
                studentLabel.Visible = true;
            }
            
            subDropDown.selectedIndex = 0;
            monthDropDown.selectedIndex = 11;
            dayDropDown.selectedIndex = 12;
            monthDropDown1.selectedIndex = 11;
            getStatistics();

        }

       void  getStatistics(){
            genSub = statisticsOP.subjectAVD(studentID);
            showQuizDay();
            showSubMonth();
            statistics_();
        }
        void studentList()
        {
            studentlearnEntities1 db = new studentlearnEntities1();
            List<user> students = (from item in db.users
                                       where item.authority == 1
                                       select item).ToList();
            studentCombobox.DataSource = students;
            studentCombobox.DisplayMember = "name";
            studentCombobox.ValueMember = "id";
        }
        public void statistics_()
        {
            chart1.Series["Paragraf"].Points.Clear();
            chart1.Series["Dil Bilgisi"].Points.Clear();
            chart1.Series["Anlatım Bozukluğu"].Points.Clear();
            chart1.Series["Şiir Bilgisi"].Points.Clear();
            chart1.Series["Divan Edebiyatı"].Points.Clear();
            chart1.Series["Paragraf"].Points.AddXY("1", genSub[0]);
            chart1.Series["Dil Bilgisi"].Points.AddXY("1", genSub[1]);
            chart1.Series["Anlatım Bozukluğu"].Points.AddXY("1", genSub[2]);
            chart1.Series["Şiir Bilgisi"].Points.AddXY("1", genSub[3]);
            chart1.Series["Divan Edebiyatı"].Points.AddXY("1", genSub[4]);
        }


        void showSubMonth()
        {

            if (subDropDown.selectedValue != null && monthDropDown.selectedValue != null)
            {
                List<int[]> sub = statisticsOP.selectSubMonth(getCategory(), (monthDropDown.selectedIndex + 1), studentID);

                chart2.Series["Ay"].Points.Clear();
                foreach (var item in sub)
                {
                    chart2.Series["Ay"].Points.AddXY(item[1], item[0]);
                }
            }
            else
            {
                MessageBox.Show("Gösterilmesini istediğiniz seçenekleri seçiniz");
            }
        }
        string getCategory()
        {
            string category = null;
            if (subDropDown.selectedIndex == 0)
            {
                category = "paragraf";
            }
            else if (subDropDown.selectedIndex == 1)
            {
                category = "dilbilgisi";
            }
            else if (subDropDown.selectedIndex == 2)
            {
                category = "anlatim";
            }
            else if (subDropDown.selectedIndex == 3)
            {
                category = "siir";
            }
            else if (subDropDown.selectedIndex == 4)
            {
                category = "divan";
            }
            return category;
        }

        private void showSubMonthButton_Click(object sender, EventArgs e)
        {
            showSubMonth();
        }


        void showQuizDay()
        {

            if (monthDropDown1.selectedValue != null && dayDropDown.selectedValue != null)
            {
                int[] getQuiz = statisticsOP.selectQuizDay((dayDropDown.selectedIndex + 1), (monthDropDown1.selectedIndex + 1), studentID);

                chart3.Series["Paragraf"].Points.Clear();
                chart3.Series["Dil Bilgisi"].Points.Clear();
                chart3.Series["Anlatım Bozukluğu"].Points.Clear();
                chart3.Series["Şiir Bilgisi"].Points.Clear();
                chart3.Series["Divan Edebiyatı"].Points.Clear();

                chart3.Series["Paragraf"].Points.AddXY("1", getQuiz[0]);
                chart3.Series["Dil Bilgisi"].Points.AddXY("1", getQuiz[1]);
                chart3.Series["Anlatım Bozukluğu"].Points.AddXY("1", getQuiz[2]);
                chart3.Series["Şiir Bilgisi"].Points.AddXY("1", getQuiz[3]);
                chart3.Series["Divan Edebiyatı"].Points.AddXY("1", getQuiz[4]);
            }
            else
            {
                MessageBox.Show("Gösterilmesini istediğiniz seçenekleri seçiniz");
            }
        }


        private void showQuizDayButton_Click(object sender, EventArgs e)
        {
            showQuizDay();
        }

        int sayac = 0;
        private void studentCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sayac>0)
            {
                studentID = (int)studentCombobox.SelectedValue;
                getStatistics();
            }
            sayac++;
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }
    }
}
