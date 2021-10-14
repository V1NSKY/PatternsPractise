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
using PatternsPractise.DAO.DAOGame;
using PatternsPractise.DAO.FactoryDAOUser;
using PatternsPractise.DAO;
using PatternsPractise.Forms;
using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
using PatternsPractise.DAO.DAOLibrary.FactoryDAOLibrary;
using static PatternsPractise.Entities.UserGameLibrary;

namespace PatternsPractise
{
    public partial class MainMenu : Form
    {
        private void GetAllGames()
        {
            CreatorDAOGame creatorDAOGame = new CreatorSQLDAOGame();
            IDAOGame daoGame = creatorDAOGame.FactoryMetod();
            List<Game> listGames = daoGame.GetAllGame();
            gameGridView.DataSource = listGames;
        }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            GetAllGames();
            Session.mainMenu = this;
        }

        private void loginInButton_Click(object sender, EventArgs e)
        {
            CreatorDAOUser creatorDAOUser = new CreatorSQLDAOUser();
            IDAOUser daoUser = creatorDAOUser.FactoryMetod();
            Session.SetUser(daoUser.GetUserById(daoUser.GetUserIdByCred(loginTextBox.Text, passwordTextBox.Text)));

            if(Session.user == null)
            {
                notUserLabel.Visible = true;
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            else
            {
                if(Session.user.UserRole == UserRole.Admin)
                {
                    addGameButton.Visible = true;
                    addUserButton.Visible = true;
                    changeGameButton.Visible = true;
                }
                notUserLabel.Visible = false;
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
                userLabel.Visible = true;
                userNameLabel.Visible = true;
                userRoleLabel.Visible = true;
                roleLabel.Visible = true;
                userNameLabel.Text = Session.user.UserName +" "+ Session.user.UserSurname;
                userRoleLabel.Text = Session.user.UserRole.ToString();
                loginInButton.Visible = false;
                logOutButton.Visible = true;
                registerButton.Visible = false;
                libraryButton.Visible = true;
                addButton.Visible = true;
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Session.NullUser();
            registerButton.Visible = true;
            userLabel.Visible = false;
            userNameLabel.Visible = false;
            userRoleLabel.Visible = false;
            roleLabel.Visible = false;
            loginInButton.Visible = true;
            logOutButton.Visible = false;
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
            addGameButton.Visible = false;
            addUserButton.Visible = false;
            changeGameButton.Visible = false;
            libraryButton.Visible = false;
            addButton.Visible = false;
            isAddedLabel.Visible = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void SearchByNameButton_Click(object sender, EventArgs e)
        {
            CreatorDAOGame creatorDAOGame = new CreatorSQLDAOGame();
            IDAOGame daoGame = creatorDAOGame.FactoryMetod();
            List<Game> listGames = daoGame.SearchGameByName(searchTextBox.Text.ToString());
            gameGridView.DataSource = listGames;
        }

        private void gameGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isAddedLabel.Visible = false;
            DataGridViewSelectedCellCollection cells = gameGridView.SelectedCells;
            Session.selectedGameid = Convert.ToInt32(cells[0].Value);
            /*Game game = new GameBuilder()
                .gameId(Convert.ToInt32(cells[0].Value))
                .gameDeveloper(cells[1].Value.ToString())
                .gamePublisher(cells[2].Value.ToString())
                .gameName(cells[3].Value.ToString())
                .gamePrice(Convert.ToDouble(cells[4].Value))
                .gameDateOfRelease(cells[5].Value.ToString())
                .gameDescription(cells[6].Value.ToString())
                .Build();*/

        }

        private void gameGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void gameInfoButton_Click(object sender, EventArgs e)
        {
            GameInfoForm gameInfoForm = new GameInfoForm();
            gameInfoForm.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(Session.user != null)
            {
                CreatorDAOUser creatorDAOUser = new CreatorSQLDAOUser();
                IDAOUser daoUser = creatorDAOUser.FactoryMetod();
                CreatorDAOGame creatorDAOGame = new CreatorSQLDAOGame();
                IDAOGame daoGame = creatorDAOGame.FactoryMetod();
                CreatorDAOLibrary creatorDAOLibrary = new CreatorSQLDAOLibrary();
                IDAOLibrary daoLibrary = creatorDAOLibrary.FactoryMetod();

                isAddedLabel.Text = daoLibrary.AddLibrary(new LibraryBuilder()
                                    .game(daoGame.GetGameById(Session.selectedGameid))
                                    .user(daoUser.GetUserById(Session.user.UserId))
                                    .Build());

                isAddedLabel.Visible = true;
            }  
        }

        private void libraryButton_Click(object sender, EventArgs e)
        {
            GameLibrary gameLibrary = new GameLibrary();
            gameLibrary.Show();
            this.Hide();
        }
    }
}
