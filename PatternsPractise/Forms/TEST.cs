using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
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

namespace PatternsPractise.Forms
{
    public partial class TEST : Form
    {

        List<GameGenre> listGenres = new List<GameGenre>();
        public TEST()
        {
            InitializeComponent();
        }

        private void TEST_Load(object sender, EventArgs e)
        {
            Session.daoGame = new CreatorDBDAOGame().FactoryMetod(Session.dbType);
            gameGridView.DataSource = Session.daoGame.GetAllGame();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Game game = new GameBuilder()
               .listGenre(listGenres)
               .gameName(addNameTextBox.Text.ToString())
               .gameDeveloper(addDeveloperTextBox.Text.ToString())
               .gamePublisher(addPublisherTextBox.Text.ToString())
               .gamePrice(Convert.ToDouble(addPriceTextBox.Text))
               .gameDateOfRelease(addDateOfRelease.Text.ToString())
               .gameDescription(addDescriptionTextBox.Text.ToString())
               .Build();
            
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            GameGenre genre = new GameGenre(addGenreTextBox.Text.ToString());
            if (genre != null)
            {
                addedGenresLabel.Text += genre.genreName + " ";
                listGenres.Add(genre);
                addGenreTextBox.Text = "";
            }
        }

        private void TEST_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBTypeForm dBTypeForm = DBTypeForm.GetDBTypeForm();
            dBTypeForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.daoGame.DeleteGame(Convert.ToInt32(textBox1.Text));
        }
    }
}
