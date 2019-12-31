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
    class StatisticsOperation:MainDatabase
    {
        public int[] subjectAVD(int studentID)
        {

            int[] avd = new int[5];
            try
            {
                mainConnect();
                MySqlCommand catSearchCommand = new MySqlCommand("Select AVG(paragraf) AS 'paragraf', AVG(dilbilgisi) AS 'dilbilgisi', AVG(anlatim) AS 'anlatim' , AVG(siir) AS 'siir' , AVG(divan) AS 'divan' from userrate WHERE userID='" + studentID + "'", mainDatabeseConn);
                MySqlDataReader reader = catSearchCommand.ExecuteReader();
                while (reader.Read())
                {
                    avd[0] = reader.GetInt32("paragraf");
                    avd[1] = reader.GetInt32("dilbilgisi");
                    avd[2] = reader.GetInt32("anlatim");
                    avd[3] = reader.GetInt32("siir");
                    avd[4] = reader.GetInt32("divan");

                }
                mainConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                mainConnect();
            }
            return avd;
        }


        public List<int[]> selectSubMonth(string sub,int month,int studentID)
        {
            List<int[]> subAVD = new List<int[]>();
            try
            {
                mainConnect();
                MySqlCommand catSearchCommand = new MySqlCommand("Select "+sub+", DAY(date) AS 'Day' from userrate WHERE userID='" + studentID + "' AND MONTH(date)= '"+month+"'" +" ORDER BY DAY(date)"  , mainDatabeseConn);
                MySqlDataReader reader = catSearchCommand.ExecuteReader();
                while (reader.Read())
                {
                    int[] lineSub = { reader.GetInt32(sub), reader.GetInt32("Day") };
                    subAVD.Add(lineSub);
                }
                mainConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                mainConnect();
            }
            return subAVD;
        }

        public int[] selectQuizDay(int day, int month,int studentID)
        {
            int[] subAVD = new int[5];
            try
            {
                mainConnect();
                MySqlCommand catSearchCommand = new MySqlCommand("Select paragraf,dilbilgisi,anlatim,siir,divan,DAY(date) AS 'Day' from userrate WHERE userID='" + studentID + "'AND DAY(date)= '"+day+"' AND MONTH(date)= '" + month + "'" + " ORDER BY DAY(date)", mainDatabeseConn);
                MySqlDataReader reader = catSearchCommand.ExecuteReader();
                while (reader.Read())
                {
                    int[] lineSub = { reader.GetInt32("paragraf"), reader.GetInt32("dilbilgisi"), reader.GetInt32("anlatim"), reader.GetInt32("siir"), reader.GetInt32("divan") };
                    subAVD = lineSub;
                }
                mainConnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("İşlem sırasında bir hata meydana geldi." + e);
                mainConnect();
            }
            return subAVD;
        }
    }
}
