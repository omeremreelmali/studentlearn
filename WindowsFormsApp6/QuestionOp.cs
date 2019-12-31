using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp6
{
    public partial class QuestionOp : UserControl
    {
        public QuestionOp()
        {
            InitializeComponent();
        }
        Classes.QuestionOperation quizOP = new Classes.QuestionOperation();
        string questionName = "", oldFileLoc = "",picName="";
        bool questionValidation = true,  replyValidation = true, reply1Validation = true, reply2Validation = true, reply3Validation = true, reply4Validation=true;
        Font qFont; 
        private void selectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileIMG = new OpenFileDialog();
            fileIMG.Filter = "Resim Dosyası |*.jpg;*.nef;*.png| Video|*.avi| Tüm Dosyalar |*.*";
            fileIMG.Title = "Resim Seçiniz";
            fileIMG.ShowDialog(); 
            picUrlTBox.Text = fileIMG.FileName;
            oldFileLoc = fileIMG.FileName.ToString();
        }
        
        private void QuestionOp_Load(object sender, EventArgs e)
        {
            qFont = questionTbox.Font;
            qListe();
            categoryList();
        }
        void categoryList()
        {
            studentlearnEntities1 dbs = new studentlearnEntities1();
            var categories = dbs.categories.ToList();
            categoryTypeCombo.DataSource = categories;
            categoryTypeCombo.DisplayMember = "name";
            categoryTypeCombo.ValueMember = "id";

        }
        Classes.questionClass[] qSaveList;
        void qListe()
        {
            questionListBox.Items.Clear();
            List<Classes.questionClass> quesss = quizOP.getQuestion(null,0,0);
            qSaveList = new Classes.questionClass[quesss.Count];
            int i = 0;
            foreach (var item in quesss)
            {
                qSaveList[i] = item;
                //questionTbox.Rtf = item.ques;
                questionListBox.Items.Add(qSaveList[i].quesText);
                i++;
            }
            
            
        }

        private void fontChangeButton_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = questionTbox.SelectionFont;
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                questionTbox.SelectionFont = fontDialog1.Font;
            }
        }

        private void colorChangeButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = questionTbox.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                questionTbox.SelectionColor = colorDialog1.Color;
            }
        }

        private void alignLeft_Click(object sender, EventArgs e)
        {
            questionTbox.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignCenter_Click(object sender, EventArgs e)
        {
            questionTbox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void alignRight_Click(object sender, EventArgs e)
        {
            questionTbox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            questionTbox.LoadFile(openFileDialog1.FileName);
            
        }

       

        private void deleteQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionListBox.SelectedItem != null)
            {
                bool ret = quizOP.deleteQuestion(qSaveList[questionListBox.SelectedIndex].id);
                if (ret)
                {
                    MessageBox.Show("Soru Başarıyla Silindi");
                    qListe();
                }
                else
                {
                    MessageBox.Show("Silinirken hata oluştu");
                }
            }
            else
            {
                MessageBox.Show("Silinecek soruyu seçiniz");
            }
        }

        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            addQuestionButton.Visible = true;
            cancelUpdateButton.Visible = false;
            questionUpdateButton.Visible = false;
            clearForms();
        }

        void clearForms()
        {
            questionTbox.Text = null;
            replyTBox.Text = null;
            replyTBox1.Text = null;
            replyTBox2.Text = null;
            replyTBox3.Text = null;
            replyTBox4.Text = null;
            picUrlTBox.Text = null;
            addQuestionButton.Visible = true;
            cancelUpdateButton.Visible = false;
            questionUpdateButton.Visible = false;
            questionName = ""; oldFileLoc = ""; picName ="";

        }

        
        bool validationReturn()
        {
            bool validationValue = true;
            int falseCount = 0;
            if (!questionValidation)
            {
                falseCount++;
            }
            if (!replyValidation)
            {
                falseCount++;
            }
            if (!reply1Validation)
            {
                falseCount++;
            }
            if (!reply2Validation)
            {
                falseCount++;
            }
            if (!reply3Validation)
            {
                falseCount++;
            }
            if (!reply4Validation)
            {
                falseCount++;
            }

            if (falseCount>0)
            {
                validationValue = false;
            }

            return validationValue;
        }
        private void questionUpdateButton_Click(object sender, EventArgs e)
        {
            if (questionTbox.Text != null && questionTbox.Text != "" && replyTBox.Text != "" && replyTBox.Text != null && categoryTypeCombo.SelectedItem != null && replyTBox1.Text != "" && replyTBox1.Text != null && replyTBox2.Text != "" && replyTBox2.Text != null && replyTBox3.Text != "" && replyTBox3.Text != null && replyTBox4.Text != "" && replyTBox4.Text != null && validationReturn())
            {

                if (questionName!=picUrlTBox.Text)
                {
                    File.Delete(@"images\\"+questionName + ".jpg");
                    File.Copy(oldFileLoc, @"images\\" + questionName + ".jpg");
                }
                File.Delete(@"question\\" + questionName + ".rtf");
                questionTbox.SaveFile(@"question\\" + questionName + ".rtf");
                //soru oluşturma
                question newQuest = new question();
                newQuest.questionText = questionTbox.Text;
                newQuest.questionName = questionName;
                newQuest.reply = replyTBox.Text;
                newQuest.reply1 = replyTBox1.Text;
                newQuest.reply2 = replyTBox2.Text;
                newQuest.reply3 = replyTBox3.Text;
                newQuest.reply4 = replyTBox4.Text;
                newQuest.categoryID = (int)categoryTypeCombo.SelectedValue;

                bool ret = quizOP.updateQuestion(newQuest);
                if (ret)
                {
                    MessageBox.Show("Sorunuz başarılı bir şekilde güncellendi.");
                    clearForms();
                    qListe();
                }


            }
            else
            {
                MessageBox.Show("Lütfen bilgileri doğru ve eksiksiz giriniz.");
            }
        }

       

        private void updateQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionListBox.SelectedItem != null)
            {

                questionTbox.LoadFile(@"question\\" + qSaveList[questionListBox.SelectedIndex].quesName+".rtf"); 
                replyTBox.Text= qSaveList[questionListBox.SelectedIndex].reply;
                replyTBox1.Text = qSaveList[questionListBox.SelectedIndex].reply1;
                replyTBox2.Text = qSaveList[questionListBox.SelectedIndex].reply2;
                replyTBox3.Text = qSaveList[questionListBox.SelectedIndex].reply3;
                replyTBox4.Text = qSaveList[questionListBox.SelectedIndex].reply4;
                picUrlTBox.Text= qSaveList[questionListBox.SelectedIndex].quesName;
                categoryTypeCombo.SelectedIndex = qSaveList[questionListBox.SelectedIndex].cat - 1;
                picName = qSaveList[questionListBox.SelectedIndex].quesName;
                questionName = qSaveList[questionListBox.SelectedIndex].quesName;

                addQuestionButton.Visible = false;
                cancelUpdateButton.Visible = true;
                questionUpdateButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Güncellenecek soruyu seçiniz.");
            }
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionTbox.Text!=null && questionTbox.Text != "" && replyTBox.Text != "" && replyTBox.Text != null && categoryTypeCombo.SelectedItem!=null && replyTBox1.Text != "" && replyTBox1.Text != null && replyTBox2.Text != "" && replyTBox2.Text != null && replyTBox3.Text != "" && replyTBox3.Text != null && replyTBox4.Text != "" && replyTBox4.Text != null && validationReturn())
            {
                
                questionName = DateTime.Now.ToString().Trim().Replace(" ", string.Empty).Trim().Replace(":", string.Empty).Trim().Replace("/", string.Empty);
                Classes.questionClass ques = new Classes.questionClass();
                if (oldFileLoc!="")
                {
                    File.Copy(oldFileLoc, @"images\\" + questionName + ".jpg");
                }
                questionTbox.SaveFile(@"question\\" + questionName + ".rtf");
                //soru oluşturma
                
                question newQuest = new question();
                newQuest.questionText = questionTbox.Text;
                newQuest.questionName = questionName;
                newQuest.reply = replyTBox.Text;
                newQuest.reply1 = replyTBox1.Text;
                newQuest.reply2 = replyTBox2.Text;
                newQuest.reply3 = replyTBox3.Text;
                newQuest.reply4 = replyTBox4.Text;
                newQuest.categoryID = (int)categoryTypeCombo.SelectedValue;
                bool ret = quizOP.addQuestion(newQuest);
                if (ret)
                {
                    MessageBox.Show("Sorunuz başarılı bir şekilde eklendi.");
                    qListe();
                    clearForms();
                }

                
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri doğru ve eksiksiz giriniz.");
            }
            
        }


        private void replyTBox_OnValueChanged(object sender, EventArgs e)
        {
            if (replyTBox.Text.Length > 600)
            {
                replyProvider.SetError(replyTBox, "Cevap 150 karakterden büyük olamaz");
                replyValidation = false;
            }
            else if (replyTBox.Text.Length < 3)
            {
                replyProvider.SetError(replyTBox, "Soru  1 karakterden küçük olamaz");
                replyValidation = false;
            }
            else
            {
                replyValidation = true;
                replyProvider.Clear();
            }
        }

        private void replyTBox1_OnValueChanged(object sender, EventArgs e)
        {
            if (replyTBox1.Text.Length > 150)
            {
                reply1Provider.SetError(replyTBox1, "Cevap 150 karakterden büyük olamaz");
                reply1Validation = false;
            }
            else if (replyTBox1.Text.Length < 1)
            {
                reply1Provider.SetError(replyTBox1, "Soru  1 karakterden küçük olamaz");
                reply1Validation = false;
            }
            else
            {
                reply1Validation = true;
                reply1Provider.Clear();
            }
        }

        private void replyTBox2_OnValueChanged(object sender, EventArgs e)
        {
            if (replyTBox2.Text.Length > 150)
            {
                reply2Provider.SetError(replyTBox2, "Cevap 150 karakterden büyük olamaz");
                reply2Validation = false;
            }
            else if (replyTBox2.Text.Length < 1)
            {
                reply2Provider.SetError(replyTBox2, "Soru  1 karakterden küçük olamaz");
                reply2Validation = false;
            }
            else
            {
                reply2Validation = true;
                reply2Provider.Clear();
            }
        }

        private void replyTBox3_OnValueChanged(object sender, EventArgs e)
        {
            if (replyTBox3.Text.Length > 150)
            {
                reply3Provider.SetError(replyTBox3, "Cevap 150 karakterden büyük olamaz");
                reply3Validation = false;
            }
            else if (replyTBox3.Text.Length < 1)
            {
                reply3Provider.SetError(replyTBox3, "Soru  1 karakterden küçük olamaz");
                reply3Validation = false;
            }
            else
            {
                reply3Validation = true;
                reply3Provider.Clear();
            }
        }

        private void replyTBox4_OnValueChanged(object sender, EventArgs e)
        {
            if (replyTBox4.Text.Length > 150)
            {
                reply4Provider.SetError(replyTBox4, "Cevap 150 karakterden büyük olamaz");
                reply4Validation = false;
            }
            else if (replyTBox4.Text.Length < 1)
            {
                reply4Provider.SetError(replyTBox4, "Soru  1 karakterden küçük olamaz");
                reply4Validation = false;
            }
            else
            {
                reply4Validation = true;
                reply4Provider.Clear();
            }
        }

        private void questionTbox_TextChanged(object sender, EventArgs e)
        {
            if (questionTbox.Text.Length > 600)
            {
                questionProvider.SetError(questionTbox, "Soru 600 karakterden büyük olamaz");
                questionValidation = false;
            }
            else if (questionTbox.Text.Length < 3)
            {
                questionProvider.SetError(questionTbox, "Soru  30 karakterden küçük olamaz");
                questionValidation = false;
            }
            else
            {
                questionValidation = true;
                questionProvider.Clear();
            }
        }






    }
}
