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
        public void ChangeCellStyle(DataGridViewCellStyle style, Color backColor, Color foreColor, Color selectionColor)
        {
            style.BackColor = backColor;
            style.ForeColor = foreColor;
            style.SelectionBackColor = selectionColor;

        }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            String constr = "server=localhost;uid=root;pwd=root;database=gamelibrarydb";
            MySqlConnection connection = SQLConnection.GetConnection(constr);

            DAOGame daoGame = new DAOGame(constr);

            List<Game> listGames = daoGame.GetAllGame();
            gameGridView.DataSource = listGames;
            
        }
    }
}
