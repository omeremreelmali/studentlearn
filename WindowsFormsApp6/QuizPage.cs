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
    public partial class QuizPage : UserControl
    {
        public QuizPage()
        {
            InitializeComponent();
        }

        Classes.QuestionOperation quizOP = new Classes.QuestionOperation();
        int[] questionRand = new int[5]; int questionNum = 0;
        int paragrafT = 0, dilbilgisiT = 0, anlatimT = 0, siirT = 0, divanT = 0;
        int paragrafF = 0, dilbilgisiF = 0, anlatimF = 0, siirF = 0, divanF = 0;
        int minute = 50,second=0;
        List<Classes.questionClass>[] quizGetQuest;
        List<Classes.questionClass> quiz = new List<Classes.questionClass>();
        
        private void QuizPage_Load(object sender, EventArgs e)
        {
            if (quizOP.quizLoginControl())
            {
                quizGetQuest = quizOP.getQuiz();
                loadQuestion();
                questionLoading();
                replyUpdate();
                timer1.Start();
                questionsCountLabel.Text = "Paragraf= " + (Classes.LoginUser.paragraf * 2) + " Dil Bilgisi= " + (Classes.LoginUser.dilbilgisi * 2) + " Anlatim Bozukluğu=" + (Classes.LoginUser.anlatim * 2) + " Şiir= " + (Classes.LoginUser.siir * 2) + " Divan= " + (Classes.LoginUser.divan * 2);
            }
            else
            {
                MessageBox.Show("Bu gün tekrar sınava giremezsiniz");
                buttonEnabledFalse();
            }
        }
        void loadQuestion()
        {
            for (int i = 0; i < quizGetQuest.Length; i++)
            {
                foreach (var item in quizGetQuest[i])
                {
                    quiz.Add(item);
                }
            }
        }



        public void questionLoading()
        {
            questionRand = new int[5];
            
            int i = 0;
            while (i < 5)
            {
                Random rand = new Random();
                int sayi = rand.Next(0, 6);
                if (questionRand.Contains(sayi))
                    continue;
                questionRand[i] = sayi;
                i++;
            }

            string picLoc = @"images\\" + quiz[questionNum].quesName + ".jpg";
            if (File.Exists(picLoc) == true)
            {
                pictureBox1.ImageLocation = picLoc;
            }
            else
            {
                pictureBox1.ImageLocation = @"images\\resyok.jpg";
            }

            questionTbox.LoadFile(@"question\\" + quiz[questionNum].quesName + ".rtf");
            optionsLoad(quiz[questionNum].reply, questionRand[0]);
            optionsLoad(quiz[questionNum].reply1, questionRand[1]);
            optionsLoad(quiz[questionNum].reply2, questionRand[2]);
            optionsLoad(quiz[questionNum].reply3, questionRand[3]);
            optionsLoad(quiz[questionNum].reply4, questionRand[4]);
        }

        void optionsLoad(string options, int num)
        {
                if (num == 1)
                {
                    aOptionsButton.ButtonText = options;
                }
                else if (num == 2)
                {
                    bOptionsButton.ButtonText = options;
                }
                else if (num == 3)
                {
                    cOptionsButton.ButtonText = options;
                }
                else if (num == 4)
                {
                    dOptionsButton.ButtonText = options;
                }
                else if (num == 5)
                {
                    eOptionsButton.ButtonText = options;
                }
        }
        

        private void AOptionsButton_Click(object sender, EventArgs e)
        {
            answerControl(1);
        }

        private void BOptionsButton_Click(object sender, EventArgs e)
        {
            answerControl(2);
        }

        private void COptionsButton_Click(object sender, EventArgs e)
        {
            answerControl(3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second == 0)
            {
                second = 60;
                minute--;
            }
            else
            {
                second--;
            }
            if (minute==0 && second==0)
            {
                MessageBox.Show("Sınav süreniz doldu.");
                quizStop();
                timer1.Stop();
            }
            else
            {
                timeLabel.Text = minute + ":" + second;
            }
        }

        private void DOptionsButton_Click(object sender, EventArgs e)
        {
            answerControl(4);
        }
        private void eOptionsButton_Click(object sender, EventArgs e)
        {
            answerControl(5);
        }

        public void answerControl(int answer)
        {
            int score = 0;
            if (answer== questionRand[0])
            {
                
                if (quiz[questionNum].cat == 1)
                {
                    paragrafT++;
                    score = paragrafT;
                }
                if (quiz[questionNum].cat == 2)
                {
                    dilbilgisiT++;
                    score = dilbilgisiT;
                }
                if (quiz[questionNum].cat == 3)
                {
                    anlatimT++;
                    score = anlatimT;
                }
                if (quiz[questionNum].cat == 4)
                {
                    siirT++;
                    score = siirT;
                }
                if (quiz[questionNum].cat == 5)
                {
                    divanT++;
                    score = divanT;
                }
                answerTrue(score, quiz[questionNum].cat);
            }
            else
            {
                if (quiz[questionNum].cat == 1)
                {
                    paragrafF++;
                    score = paragrafF;
                }
                if (quiz[questionNum].cat == 2)
                {
                    dilbilgisiF++;
                    score = dilbilgisiF;
                }
                if (quiz[questionNum].cat == 3)
                {
                    anlatimF++;
                    score = anlatimF;
                }
                if (quiz[questionNum].cat == 4)
                {
                    siirF++;
                    score = siirF;
                }
                if (quiz[questionNum].cat == 5)
                {
                    divanF++;
                    score = divanF;
                }
                answerFalse(score, quiz[questionNum].cat);
            }

            if (questionNum<49)
            {
                questionNum++;
                questionNumberLabel.Text = (questionNum + 1) + "";
                questionLoading();
            }
            else
            {
                MessageBox.Show("Sınav Bitti");
                quizStop();
                buttonEnabledFalse();
            }
            replyUpdate();
        }

        void quizStop()
        {
            timer1.Stop();
            int mark = (paragrafT + dilbilgisiT + anlatimT + siirT + divanT)*2;
            quiz newQuiz = new quiz();
            newQuiz.userID =Convert.ToInt32( Classes.LoginUser.userID);
            newQuiz.paragrafTrue = paragrafT;
            newQuiz.paragrafFalse = paragrafF;
            newQuiz.dilbilgisiTrue = dilbilgisiT;
            newQuiz.dilbilgisiFalse = dilbilgisiF;
            newQuiz.anlatimTrue = anlatimT;
            newQuiz.anlatimFalse = anlatimF;
            newQuiz.siirTrue = siirT;
            newQuiz.siirFalse = siirF;
            newQuiz.divanTrue = divanT;
            newQuiz.divanFalse = divanF;
            newQuiz.quizMark = mark;
            newQuiz.date = DateTime.Now;
            quizOP.saveQuiz(newQuiz);
        }
        void answerTrue(int score, int category)
        {
            if (score % 2 == 0)
            {
                if (category == 1 && Classes.LoginUser.paragraf != 1)
                {
                    Classes.LoginUser.paragraf--;
                }
                if (category == 2 && Classes.LoginUser.dilbilgisi != 1)
                {
                    Classes.LoginUser.dilbilgisi--;
                }
                if (category == 3 && Classes.LoginUser.anlatim != 1)
                {
                    Classes.LoginUser.anlatim--;
                }
                if (category == 4 && Classes.LoginUser.siir != 1)
                {
                    Classes.LoginUser.siir--;
                }
                if (category == 5&& Classes.LoginUser.divan!=1)
                {
                    Classes.LoginUser.divan--;
                }
            }
        }

        void answerFalse(int score, int category)
        {
            if (score % 2 == 0)
            {
                if (category == 1 && Classes.LoginUser.paragraf != 5)
                {
                    Classes.LoginUser.paragraf++;
                }
                if (category == 2 && Classes.LoginUser.dilbilgisi != 5)
                {
                    Classes.LoginUser.dilbilgisi++;
                }
                if (category == 3 && Classes.LoginUser.anlatim != 5)
                {
                    Classes.LoginUser.anlatim++;
                }
                if (category == 4 && Classes.LoginUser.siir != 5)
                {
                    Classes.LoginUser.siir++;
                }
                if (category == 5 && Classes.LoginUser.divan != 5)
                {
                    Classes.LoginUser.divan++;
                }
            }
        }

        void buttonEnabledFalse()
        {
            aOptionsButton.Enabled = false;
            bOptionsButton.Enabled = false;
            cOptionsButton.Enabled = false;
            dOptionsButton.Enabled = false;
            eOptionsButton.Enabled = false;
        }

        void replyUpdate()
        {
            trueReply.Text = "Paragraf= " + paragrafT + " Dil Bilgisi= " + dilbilgisiT + " Anlatim Bozukluğu=" + anlatimT + " Şiir= " + siirT + " Divan= " + divanT;
            falseReply.Text = "Paragraf= " + paragrafF + " Dil Bilgisi= " + dilbilgisiF + " Anlatim Bozukluğu=" + anlatimF + " Şiir= " + siirF + " Divan= " + divanF;
        }
    }
}
