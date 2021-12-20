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
            var timer = System.Diagnostics.Stopwatch.StartNew();
            var collection = daoSys.Agr_query_1();
            timer.Stop();
            MessageBox.Show(
                "Запрос 1\n"+"Время выполнения: "+ timer.Elapsed.TotalSeconds+" c",
                "Тест",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
            textBox1.Text = "Кол-во игр, с системными требованиями, где процессор Intel Core I5\r\n";
            foreach (BsonDocument document in collection)
            {
                textBox1.Text += document.ToString() + "\r\n|||\r\n|||\r\n";
            }
        }

        private void query2Button_Click(object sender, EventArgs e)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();
            var collection = daoSys.Agr_query_2();
            timer.Stop();
            MessageBox.Show(
                "Запрос 2\n" + "Время выполнения: " + timer.Elapsed.TotalSeconds + " c",
                "Тест",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
            textBox1.Text = "Кол-во игр по их разработчикам\r\n";
            foreach (BsonDocument document in collection)
            {
                textBox1.Text += document.ToString() + "\r\n|||\r\n|||\r\n";
            }
        }

        private void query3Button_Click(object sender, EventArgs e)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();
            var collection = daoSys.Agr_query_3();
            timer.Stop();
            MessageBox.Show(
                "Запрос 3\n" + "Время выполнения: " + timer.Elapsed.TotalSeconds + " c",
                "Тест",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
            textBox1.Text = "Кол-во игр, с системными требованиями, где кол-во оперативной памяти между 4 и 12, отсортировано по убыванию\r\n";
            foreach (BsonDocument document in collection)
            {
                textBox1.Text += document.ToString() + "\r\n|||\r\n|||\r\n";
            }
        }

        private void query4Button_Click(object sender, EventArgs e)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();
            var collection = daoSys.Agr_query_4();
            MessageBox.Show(
                "Запрос 4\n" + "Время выполнения: " + timer.Elapsed.TotalSeconds + " c",
                "Тест",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
            textBox1.Text = "Кол-во игр, с системными требованиями, равными: GeForce RTX 2070, Ryzen 7, группировка по ОС\r\n";
            foreach (BsonDocument document in collection)
            {
                textBox1.Text += document.ToString() + "\r\n|||\r\n|||\r\n";
            }
        }

        private void query5Button_Click(object sender, EventArgs e)
        {
            var timer = System.Diagnostics.Stopwatch.StartNew();
            var collection = daoSys.Agr_query_5();
            MessageBox.Show(
                "Запрос 5\n" + "Время выполнения: " + timer.Elapsed.TotalSeconds + " c",
                "Тест",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1
            );
            textBox1.Text = "Кол-во игр с ОС 'Linux'\r\n";
            foreach (BsonDocument document in collection)
            {
                textBox1.Text += document.ToString() + "\r\n|||\r\n|||\r\n";
            }
        }
    }
}
