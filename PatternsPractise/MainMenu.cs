using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PatternsPractise.Connection;
using PatternsPractise.Entities;
using static PatternsPractise.Entities.Game;
using static PatternsPractise.Entities.User;
using static PatternsPractise.Entities.SystemReq;
using PatternsPractise.DAO;

namespace PatternsPractise
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            String constr = "server=localhost;uid=root;pwd=root;database=gamelibrarydb";
            MySqlConnection connection = SQLConnection.GetConnection(constr);
            
            try
            {
                connection.Open();
                connectionLabel.Text = "Подключение: подключено; База данных: "+connection.Database;
                connection.Close();
            }
            catch(Exception ex)
            {
                connectionLabel.Text = "Подключение: "+ ex.Message;
            }
            DAOGame dao = new DAOGame(connection);
            List<Game> game = dao.GetAllGame();
            foreach(Game game1 in game)
            {
                game1.GameGenre = dao.getGameGenres(game1.GameId);
            }
            TestView.DataSource = game;

            DAOGame dao1 = new DAOGame(connection);
            /*Game game = new GameBuilder()
                .gameName("bf5")
                .gameDeveloper("ea")
                .gamePublisher("ea")
                .gamePrice(60)
                .gameDateOfRelease("2015.10.20")
                .AddGenreBuilder(new GameGenre("Шутер"))
                .AddGenreBuilder(new GameGenre("Хоррор"))
                .Build();
            connectionLabel.Text = game.ToString();
            TestLabel.Text = dao.addGame(game); */
            /*User user = new UserBuilder(1)
                .userName("Максим")
                .userSurname("Кутвицкий")
                .userMiddleName("Юрьевич")
                .userLogin("user")
                .userPassword("password")
                .userPhone("0960039001")
                .userDescription("додик")
                .Build();
            connectionLabel.Text = user.ToString();*/
            /*SystemReq systemReq = new ReqBuilder()
                .sr_OS("Windows 10")
                .processor("I7-9900K")
                .sr_video("Nvidia GeForce GTX 3090")
                .sr_RAM(16)
                .sr_space(75)
                .Build();
            connectionLabel.Text = systemReq.ToString();*/
        }
    }
}
