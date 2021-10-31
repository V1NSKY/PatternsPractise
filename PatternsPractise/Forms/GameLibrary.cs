using PatternsPractise.DAO;
using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
using PatternsPractise.DAO.DAOLibrary.FactoryDAOLibrary;
using PatternsPractise.DAO.ObserverDAO;
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

namespace PatternsPractise.Forms
{
    public partial class GameLibrary : Form
    {
        private static GameLibrary gameLibrary;
        private ObserverDAOLibrary observer;
        private GameLibrary()
        {
            InitializeComponent();
        }
        public static GameLibrary GetGameLibrary()
        {
            if (gameLibrary == null || gameLibrary.IsDisposed)
            {
                return gameLibrary = new GameLibrary();
            }
            else
            {
                return gameLibrary;
            }
        }
        private void ShowLibrary()
        {
            List<UserGameLibrary> userGames = new List<UserGameLibrary>();
            userGames = Session.daoLibrary.GetAllUserLibrary(Session.user.UserId);

            if(userGames != null)
            {
                foreach (UserGameLibrary library in userGames)
                {
                    library.Game = Session.daoGame.GetGameById(library.Game.GameId);
                }
                gameGridView.DataSource = userGames;
            }
            
        }
        private void GameLibrary_Load(object sender, EventArgs e)
        {
            this.observer = new ObserverDAOLibrary(gameGridView);
            Session.daoLibrary.AddObserver(this.observer);
            ShowLibrary();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Session.mainMenu.Show();
            this.Close();
        }

        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cells = gameGridView.SelectedCells;

            if(Session.daoLibrary.DeleteLibraryGame(Convert.ToInt32(cells[1].Value)) != 0)
            {
                isDeletedLabel.Visible = true;
                isDeletedLabel.Text = "Игра удалена из библиотеки";
            }
            
        }

        private void gameGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gameGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 76, 41);
        }

        private void gameGridView_SelectionChanged(object sender, EventArgs e)
        {
            gameGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 57, 75);
        }

        private void GameLibrary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Session.daoLibrary.DeleteObserver(this.observer);
        }
    }
}
