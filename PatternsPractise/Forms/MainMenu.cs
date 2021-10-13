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

            DAOGame daoGame = new DAOGame();

            List<Game> listGames = daoGame.GetAllGame();
            gameGridView.DataSource = listGames;
            
        }

        private void loginInButton_Click(object sender, EventArgs e)
        {
            DAOUser dAOUser = new DAOUser();
            Session.SetUser(dAOUser.GetUserById(dAOUser.GetUserIdByCred(loginTextBox.Text, passwordTextBox.Text)));

            if(Session.user == null)
            {
                notUserLabel.Visible = true;
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            else
            {
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
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Session.NullUser();
            userLabel.Visible = false;
            userNameLabel.Visible = false;
            userRoleLabel.Visible = false;
            roleLabel.Visible = false;
            loginInButton.Visible = true;
            logOutButton.Visible = false;
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
