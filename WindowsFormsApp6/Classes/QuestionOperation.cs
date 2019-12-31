using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace WindowsFormsApp6.Classes
{
    class QuestionOperation:MainDatabase
    {
        

        public bool quizLoginControl()
        {
            bool quizLogin = true; 
            try
            {
                 int id = Convert.ToInt32(LoginUser.userID);
                using (studentlearnEntities1 db=new studentlearnEntities1())
                {
                    quiz canEnter = (from enter in db.quizs
                                     where enter.userID == id  && enter.date.Day == DateTime.Today.Day && enter.date.Month == DateTime.Today.Month && enter.date.Year == DateTime.Today.Year
                                     select enter).FirstOrDefault();
                    if (canEnter!=null)
                    {
                        quizLogin = false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
            }
            return quizLogin;
        }
        public List<questionClass>[] getQuiz()
        {
            List<questionClass>[] quiz = new List<questionClass>[5];
            int paragraf = 0,dilbilgisi=0,anlatim=0,siir=0,divan=0,userCount=0;
            try
            {
                int id = Convert.ToInt32(LoginUser.userID);
                using (studentlearnEntities1 db = new studentlearnEntities1())
                {
                    userrate rateSearch =  (from item in db.userrates
                                     where item.userID == id orderby item.date descending
                                     select item).FirstOrDefault();
                    if (rateSearch != null)
                    {
                        paragraf = rateSearch.paragraf;
                        dilbilgisi = rateSearch.dilbilgisi;
                        anlatim = rateSearch.anlatim;
                        siir = rateSearch.siir;
                        divan = rateSearch.divan;
                        userCount++;
                    }
                    else
                    {
                        MessageBox.Show("Bu sınava kayıtlı değilsiniz.");
                    }
                }

             
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
            }

            LoginUser.paragraf = paragraf;
            LoginUser.dilbilgisi = dilbilgisi;
            LoginUser.anlatim = anlatim;
            LoginUser.siir = siir;
            LoginUser.divan = divan;


            quiz[0] = getQuestion("notNull", 1, paragraf);
            quiz[1] = getQuestion("notNull", 2, dilbilgisi);
            quiz[2] = getQuestion("notNull", 3, anlatim);
            quiz[3] = getQuestion("notNull", 4, siir);
            quiz[4] = getQuestion("notNull", 5, divan);

            return quiz;
        }

            
        public void saveQuiz(quiz newQuiz)
        {
             
            try
            {
                using (studentlearnEntities1 db = new studentlearnEntities1())
                {
                    db.quizs.Add(newQuiz);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
            }

            calcRate();

            try
            {
                userrate newUserRate = new userrate();
                newUserRate.userID = Convert.ToInt32(LoginUser.userID);
                newUserRate.paragraf = LoginUser.paragraf;
                newUserRate.dilbilgisi = LoginUser.dilbilgisi;
                newUserRate.anlatim = LoginUser.anlatim;
                newUserRate.siir = LoginUser.siir;
                newUserRate.divan = LoginUser.divan;
                newUserRate.date = DateTime.Now;

                using (studentlearnEntities1 db = new studentlearnEntities1())
                {
                    db.userrates.Add(newUserRate);
                    db.SaveChanges();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
            }  
        }
        int[] rates;
        void calcRate()
        {
            int count = 1; int gecici = 0, gecici1 = 0; bool rateB = true;
            int[] rates1 = { LoginUser.paragraf , LoginUser.dilbilgisi, LoginUser.anlatim, LoginUser.siir, LoginUser.divan };
            rates = rates1;
            int[] ratesID = { 1,2,3,4,5};

            for (int i = 0; i < 5; i++)
            {
                for (int t = 0; t < 5; t++)
                {
                    if (rates[t] < rates[i])
                    {

                        gecici = rates[i];
                        rates[i] = rates[t];
                        rates[t] = gecici;

                        gecici1 = ratesID[i];
                        ratesID[i] = ratesID[t];
                        ratesID[t] = gecici1;

                    }
                }
            }

            MessageBox.Show(""+ rates[0]+ rates[1]+ rates[2]+ rates[3]+ rates[4]);


            while (rateB)
            {
                if (calcRateTotal() != 25)
                {
                    rates[count]++;
                    count++;
                }
                
                if (calcRateTotal() == 25)
                {
                    rateB = false;
                }
                else if (calcRateTotal() != 25 && count == 4)
                {
                    count = 0;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                saveRate(ratesID[i],rates[i]);
            }
            

        }

        void saveRate(int cat,int rate)
        {
            if (cat==1)
            {
                LoginUser.paragraf = rate;
            }
            else if (cat==2)
            {
                LoginUser.dilbilgisi = rate;
            }
            else if (cat == 3)
            {
                LoginUser.anlatim= rate;
            }
            else if (cat == 4)
            {
                LoginUser.siir = rate;
            }
            else if (cat == 5)
            {
                LoginUser.divan = rate;
            }
        }
        int calcRateTotal()
        {
            int total = rates[0] + rates[1] + rates[2] + rates[3] + rates[4];
            return total;
        }

        public List<questionClass> getQuestion(string searchType,int catID,int questRate)
        {
            List<questionClass> questions = new List<questionClass>();
            try
            {
                mainConnect();
                MySqlCommand qSearchCommand= new MySqlCommand();
                if (searchType!=null)
                {
                    qSearchCommand= new MySqlCommand("Select * from question WHERE categoryID='" + catID + "'"+" ORDER BY RAND() LIMIT "+(questRate*2).ToString() , mainDatabeseConn);
                }
                else
                {
                    qSearchCommand= new MySqlCommand("Select * from question", mainDatabeseConn);
                }

                MySqlDataReader reader = qSearchCommand.ExecuteReader();
                while (reader.Read())
                {
                    questionClass quest = new questionClass();
                    quest.id = reader.GetInt32("id");
                    quest.quesText = reader.GetString("questionText").Trim().Replace("\n", " ");
                    quest.quesName = reader.GetString("questionName");
                    quest.reply = reader.GetString("reply");
                    quest.reply1 = reader.GetString("reply1");
                    quest.reply2 = reader.GetString("reply2");
                    quest.reply3 = reader.GetString("reply3");
                    quest.reply4 = reader.GetString("reply4");
                    quest.cat= reader.GetInt32("categoryID");
                    questions.Add(quest);
                }
                mainConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                mainConnect();
            }

            return questions;
        }

        public bool addQuestion(question quest)
        {
            bool result = false;
            try
            {
                using (studentlearnEntities1 db = new studentlearnEntities1())
                {
                    db.questions.Add(quest);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                result = false;
                mainConnect();
            }
            return result;
        }



        public bool updateQuestion(question updateQuest)
        {
            bool result = false;
            try
            {
                using (studentlearnEntities1 db = new studentlearnEntities1())
                {
                    var uQ = db.questions.Where(w => w.questionName == updateQuest.questionName).FirstOrDefault();
                    uQ.questionText = updateQuest.questionText;
                    uQ.reply = updateQuest.reply;
                    uQ.reply1 = updateQuest.reply1;
                    uQ.reply2 = updateQuest.reply2;
                    uQ.reply3 = updateQuest.reply3;
                    uQ.reply4 = updateQuest.reply4;
                    uQ.categoryID = updateQuest.categoryID;
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                result = false;
            }
            return result;
        }

        public bool deleteQuestion(int qid)
        {
            bool result = false;
            try
            {

                using (studentlearnEntities1 db = new studentlearnEntities1())
                {
                    var deleteQuestion = db.questions.Where(w => w.id == qid).FirstOrDefault();
                    db.questions.Remove(deleteQuestion);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                result = false;
            }
            return result;
        }
    }
}
