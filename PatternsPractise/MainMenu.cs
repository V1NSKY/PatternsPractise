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

        }
    }
}
