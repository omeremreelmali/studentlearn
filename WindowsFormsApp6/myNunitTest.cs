using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    [TestFixture]
    class myNunitTest
    {
        [TestCase]
        public void addQuestion()
        {
            Classes.QuestionOperation quizOp = new Classes.QuestionOperation();
            question quest = new question();
            quest.questionName = "Demo";
            quest.questionText = "Demo Sorusu";
            quest.reply = "1";
            quest.reply1 = "2";
            quest.reply2 = "3";
            quest.reply3 = "4";
            quest.reply4 = "5";
            quest.categoryID = 6;

            Assert.AreEqual(true,quizOp.addQuestion(quest));
        }

        [TestCase]
        public void login()
        {
            Classes.Crud crudOp = new Classes.Crud();
            string[] user = { "7", "ogrenci", "ogr", "1" };
            Assert.AreEqual(user, crudOp.userLogin("ogr","demo123")); 
        }
        [TestCase]
        public void deleteQuestion()
        {
            Classes.QuestionOperation quizOp = new Classes.QuestionOperation();
            Assert.AreEqual(true, quizOp.deleteQuestion(154));
        }
    }
}
