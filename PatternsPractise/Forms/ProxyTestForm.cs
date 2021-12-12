using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatternsPractise.DAO;
using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
using PatternsPractise.DAO.DataDAOGame;
using PatternsPractise.DAO.FactoryDAOUser;
using PatternsPractise.DAO.ObserverDAO;
using PatternsPractise.Entities;
using static PatternsPractise.Entities.Game;

namespace PatternsPractise.Forms
{
    public partial class ProxyTestForm : Form
    {
        private ProxyDAOGame proxyDaoGame;
        private Game game;
        public ProxyTestForm()
        {
            InitializeComponent();
        }

        private void ProxyTestForm_Load(object sender, EventArgs e)
        {
            IDAOGame daoGame = new CreatorDBDAOGame().FactoryMetod(DBtype.MySQL);
            Session.daoGame = daoGame;
            this.proxyDaoGame = new ProxyDAOGame(daoGame);
            proxyDaoGame.AddObserver(new ObserverDAOGame(gameGridView));
            gameGridView.DataSource = proxyDaoGame.GetAllGame();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addNameTextBox.Text = String.Empty;
            addDateOfRelease.Text = String.Empty;
            addDescriptionTextBox.Text = String.Empty;
            addDeveloperTextBox.Text = String.Empty;
            addPublisherTextBox.Text = String.Empty;
            addPriceTextBox.Text = String.Empty;
        }

        private void gameGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gameGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 76, 41);
            DataGridViewSelectedCellCollection cells = gameGridView.SelectedCells;
            Session.selectedGameid = Convert.ToInt32(cells[0].Value);
            this.game = proxyDaoGame.GetGameById(Session.selectedGameid);
            addNameTextBox.Text = game.GameName;
            addDeveloperTextBox.Text = game.GameDeveloper;
            addPublisherTextBox.Text = game.GamePublisher;
            addPriceTextBox.Text = game.GamePrice.ToString();
            addDateOfRelease.Text = game.DateOfRelease;
            addDescriptionTextBox.Text = game.GameDescription;
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            Game game = new GameBuilder()
                .gameName(addNameTextBox.Text.ToString())
                .gameDeveloper(addDeveloperTextBox.Text.ToString())
                .gamePublisher(addPublisherTextBox.Text.ToString())
                .gamePrice(Convert.ToDouble(addPriceTextBox.Text))
                .gameDateOfRelease(addDateOfRelease.Text.ToString())
                .gameDescription(addDescriptionTextBox.Text.ToString())
                .Build();
            proxyDaoGame.AddGame(game);
        }

        private void changeGameButton_Click(object sender, EventArgs e)
        {
            Game newGame = new GameBuilder()
                .gameId(this.game.GameId)
                .gameName(addNameTextBox.Text.ToString())
                .gameDeveloper(addDeveloperTextBox.Text.ToString())
                .gamePublisher(addPublisherTextBox.Text.ToString())
                .gamePrice(Convert.ToDouble(addPriceTextBox.Text))
                .gameDateOfRelease(addDateOfRelease.Text.ToString())
                .gameDescription(addDescriptionTextBox.Text.ToString())
                .Build();
            proxyDaoGame.UpdateGame(newGame);
        }

        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            proxyDaoGame.DeleteGame(this.game.GameId);
        }

        private void loginInButton_Click(object sender, EventArgs e)
        {
            Session.SetUser(new CreatorDBDAOUser().FactoryMetod(DBtype.MySQL).GetUserById(new CreatorDBDAOUser().FactoryMetod(DBtype.MySQL).GetUserIdByCred(loginTextBox.Text, passwordTextBox.Text)));
            userRoleLabel.Text = Session.user.UserRole.ToString();
            userNameLabel.Text = Session.user.UserName;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Session.NullUser();
        }
    }
}
