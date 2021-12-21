using MongoDB.Bson;
using PatternsPractise.DAO;
using PatternsPractise.DAO.DAOSystemReq.FactorySystemReq;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PatternsPractise.Entities.Game;
using static PatternsPractise.Entities.SystemReq;

namespace PatternsPractise.Forms
{
    public partial class AggregationForm : Form
    {
        private IDAOSystemReq daoSys = new CreatorDBDAOSystemReq().FactoryMetod(DBtype.MongoDB);
        public AggregationForm()
        {
            InitializeComponent();
        }

        private string Query_1()
        {
            int gameCount = 0;
            List<SystemReq> listReqs = daoSys.GetAllSystemReq();
            foreach(SystemReq systemReq in listReqs)
            {
                if (systemReq.Processor.Equals("Intel Core I5"))
                {
                    gameCount++;
                }
            }
            return "Processor: Intel Core I5, GameCount: " + gameCount;
        }
        private string Query_2()
        {
            Dictionary<string, int> developersGame = new Dictionary<string, int>();
            int gameCount = 0;
            List<SystemReq> listReqs = daoSys.GetAllSystemReq();
            List<string> listDevelopers = new List<string>();
            string returnString = "";
            foreach (SystemReq systemReq in listReqs)
            {
                string developer = systemReq.Game.GameDeveloper;
            
                if (!listDevelopers.Contains(developer))
                {
                    listDevelopers.Add(developer);
                }
            }
            for(int developerIndex = 0; developerIndex <= listDevelopers.Count - 1; developerIndex++)
            {
                gameCount = 0;
                foreach (SystemReq systemReq in listReqs)
                {
                    if(systemReq.Game.GameDeveloper == listDevelopers[developerIndex])
                    {
                        gameCount++;
                    }
                }
                returnString += "Developer: " + listDevelopers[developerIndex] + ", GameCount: " + gameCount +"\r\n";
            }
            return returnString;
        }
        private string Query_3()
        {
            string returnString = "";
            List<SystemReq> listReqs = daoSys.GetAllSystemReq();
            for (int ram = 12; ram >= 4; ram--)
            {
                int gameCount = 0;
                foreach (SystemReq systemReq in listReqs)
                {
                    if (systemReq.Sr_RAM == ram)
                    {
                        gameCount++;
                    }
                }
                returnString += "RAM: "+ram + ", GameCount: " + gameCount+"\r\n";
            }
            return returnString;
        }
        private string Query_4()
        {
            string returnString = "";
            List<SystemReq> listReqs = daoSys.GetAllSystemReq();
            List<string> listOS = new List<string>();
            foreach(SystemReq systemReq in listReqs)
            {
                if (!listOS.Contains(systemReq.Sr_OS))
                {
                    listOS.Add(systemReq.Sr_OS);
                }
            }
            for(int osIndex = 0; osIndex <= listOS.Count - 1; osIndex++)
            {
                int gameCount = 0;
                foreach (SystemReq systemReq in listReqs)
                {
                    if(systemReq.Sr_Video == "GeForce RTX 2070" && systemReq.Processor == "Ryzen 7" && systemReq.Sr_OS == listOS[osIndex])
                    {
                        gameCount++;
                    }
                }
                returnString += listOS[osIndex] + ", GameCount: "+ gameCount+"\r\n";
            }
            return returnString;
        }
        private string Query_5()
        {
            int gameCount = 0;
            List<SystemReq> listReqs = daoSys.GetAllSystemReq();
            List<string> listOS = new List<string>();
            foreach(SystemReq systemReq in listReqs)
            {
                if(systemReq.Sr_OS == "Linux")
                {
                    gameCount++;
                }
            }
            return "Linux, GameCount: " + gameCount;
        }
        private void AggregationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            string[] developers = { "Electronic Arts", "Valve", "Blizzard", "Capcom", "Bethesda Softworks" };
            string[] genres = { "Симулятор", "Приключения", "Спорт", "Головоломки", "Шутер", "Аркада" };
            Random random = new Random();
            int writeCount = 0;
            for (int writeIndex = 0; writeIndex <= Convert.ToInt32(fillTextBox.Text); writeIndex++)
            {
                List<GameGenre> listGameGenres = new List<GameGenre>();
                for (int genreIndex = 0; genreIndex <= random.Next(1, 3); genreIndex++)
                {
                    string genre = genres[random.Next(0, 5)];
                    foreach (GameGenre genreInList in listGameGenres)
                    {
                        while (genreInList.genreName == genre)
                        {
                            genre = genres[random.Next(0, 5)];
                        }
                    }
                    GameGenre gameGenre = new GameGenre(genre);
                    listGameGenres.Add(gameGenre);
                }

                Game newGame = new GameBuilder()
               .listGenre(listGameGenres)
               .gameName("Игра" + writeIndex)
               .gameDeveloper(developers[random.Next(0, 4)])
               .gamePublisher(developers[random.Next(0, 4)])
               .gamePrice(random.NextDouble() * 10)
               .gameDateOfRelease(DateTime.Now.ToString())
               .gameDescription("Описание" + writeIndex)
               .Build();

                string[] OS = { "Windows 10", "Linux", "MacOS" };
                string[] proc = { "Intel Core I5", "Intel Core I3", "Intel Core I7", "Intel Core I9", "Ryzen 7", "Ryzen 5" };
                string[] video = { "GeForce GTX 960", "GeForce RTX 2070", "GeForce RTX 2080", "GeForce RTX 2090", "GeForce RTX 3070", "GeForce RTX 3090" };

                SystemReq minSystemReq = new ReqBuilder()
                            .idSystemReqType(1)
                            .game(newGame)
                            .sr_OS(OS[random.Next(0, 2)])
                            .processor(proc[random.Next(0, 5)])
                            .sr_video(video[random.Next(0, 5)])
                            .sr_RAM(Convert.ToUInt32(random.Next(2, 16)))
                            .sr_space(Convert.ToUInt32(random.Next(10, 70)))
                            .Build();
                daoSys.AddSystemReq(minSystemReq);

                SystemReq maxSystemReq = new ReqBuilder()
                            .idSystemReqType(2)
                            .game(newGame)
                            .sr_OS(OS[random.Next(0, 2)])
                            .processor(proc[random.Next(0, 5)])
                            .sr_video(video[random.Next(0, 5)])
                            .sr_RAM(Convert.ToUInt32(random.Next(2, 16)))
                            .sr_space(Convert.ToUInt32(random.Next(10, 70)))
                            .Build();
                daoSys.AddSystemReq(maxSystemReq);
                writeCount = writeIndex;
            }
            MessageBox.Show
                (
                "Заполнение завершено" + "\n" + "Кол-во записей: " + writeCount*2,
                "Заполнено",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
                );
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            daoSys.TruncateSysReq();
            MessageBox.Show
                (
                "Очистка завершена",
                "Очещено",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
                );
        }

        private void query1Button_Click(object sender, EventArgs e)
        {
            string returnString = "Запрос 1\n" + "Время выполнения (с агрегацией): ";
            var timer = System.Diagnostics.Stopwatch.StartNew();
            var collection = daoSys.Agr_query_1();
            timer.Stop();
            returnString += timer.Elapsed.TotalSeconds + " c\r\n";
            textBox1.Text = "Кол-во игр, с системными требованиями, где процессор Intel Core I5\r\n";
            foreach (BsonDocument document in collection)
            {
                textBox1.Text += document.ToString() + "\r\n|||\r\n|||\r\n";
            }
            timer.Restart();
            textBox1.Text += Query_1();
            timer.Stop();
            returnString += "Время выполнения (без агрегации): " + timer.Elapsed.TotalSeconds + " c\r\n";
            MessageBox.Show(
                returnString,
                "Тест",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
        }

        private void query2Button_Click(object sender, EventArgs e)
        {
            string returnString = "Запрос 2\n" + "Время выполнения (с агрегацией): ";
            var timer = System.Diagnostics.Stopwatch.StartNew();
            var collection = daoSys.Agr_query_2();
            timer.Stop();
            returnString += timer.Elapsed.TotalSeconds + " c\r\n";
            textBox1.Text = "Кол-во игр по их разработчикам\r\n";
            foreach (BsonDocument document in collection)
            {
                textBox1.Text += document.ToString() + "\r\n|||\r\n|||\r\n";
            }
            timer.Restart();
            textBox1.Text += Query_2();
            timer.Stop();
            returnString += "Время выполнения (без агрегации): " + timer.Elapsed.TotalSeconds + " c\r\n";
            MessageBox.Show(
               returnString,
               "Тест",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1
           );
        }

        private void query3Button_Click(object sender, EventArgs e)
        {
            string returnString = "Запрос 3\n" + "Время выполнения (с агрегацией): ";
            var timer = System.Diagnostics.Stopwatch.StartNew();
            var collection = daoSys.Agr_query_3();
            timer.Stop();
            returnString += timer.Elapsed.TotalSeconds + " c\r\n";
            textBox1.Text = "Кол-во игр, с системными требованиями, где кол-во оперативной памяти между 4 и 12, отсортировано по убыванию\r\n";
            foreach (BsonDocument document in collection)
            {
                textBox1.Text += document.ToString() + "\r\n|||\r\n|||\r\n";
            }
            timer.Restart();
            textBox1.Text += Query_3();
            timer.Stop();
            returnString += "Время выполнения (без агрегации): " + timer.Elapsed.TotalSeconds + " c\r\n";
            MessageBox.Show(
                returnString,
                "Тест",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
        }

        private void query4Button_Click(object sender, EventArgs e)
        {
            string returnString = "Запрос 4\n" + "Время выполнения (с агрегацией): ";
            var timer = System.Diagnostics.Stopwatch.StartNew();
            var collection = daoSys.Agr_query_4();
            timer.Stop();
            returnString += timer.Elapsed.TotalSeconds + " c\r\n";
            textBox1.Text = "Кол-во игр, с системными требованиями, равными: GeForce RTX 2070, Ryzen 7, группировка по ОС\r\n";
            foreach (BsonDocument document in collection)
            {
                textBox1.Text += document.ToString() + "\r\n|||\r\n|||\r\n";
            }
            timer.Restart();
            textBox1.Text += Query_4();
            timer.Stop();
            returnString += "Время выполнения (без агрегации): " + timer.Elapsed.TotalSeconds + " c\r\n";
            MessageBox.Show(
                returnString,
                "Тест",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
        }

        private void query5Button_Click(object sender, EventArgs e)
        {
            string returnString = "Запрос 5\n" + "Время выполнения (с агрегацией): ";
            var timer = System.Diagnostics.Stopwatch.StartNew();
            var collection = daoSys.Agr_query_5();
            timer.Stop();
            returnString += timer.Elapsed.TotalSeconds + " c\r\n";
            textBox1.Text = "Кол-во игр с ОС 'Linux'\r\n";
            foreach (BsonDocument document in collection)
            {
                textBox1.Text += document.ToString() + "\r\n|||\r\n|||\r\n";
            }
            timer.Restart();
            textBox1.Text += Query_5();
            timer.Stop();
            returnString += "Время выполнения (без агрегации): " + timer.Elapsed.TotalSeconds + " c\r\n";
            MessageBox.Show(
               returnString,
               "Тест",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1
           );
        }
    }
}
