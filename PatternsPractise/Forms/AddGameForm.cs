using PatternsPractise.DAO;
using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
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
    public partial class AddGameForm : Form
    {
        private List<GameGenre> listGenres = new List<GameGenre>();
        private static AddGameForm addGameForm;
        private AddGameForm()
        {
            InitializeComponent();
        }
        public static AddGameForm GetAddGameForm()
        {
            if(addGameForm == null || addGameForm.IsDisposed)
            {
                return addGameForm = new AddGameForm();
            }
            else
            {
                return addGameForm;
            }
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

            Session.daoGame.AddGame(game);
            game = Session.daoGame.GetGameByName(game.GameName);

            SystemReq minSystemReq = new ReqBuilder()
                .idSystemReqType(1)
                .game(game)
                .sr_OS(minOSTextBox.Text)
                .processor(minProcTextBox.Text)
                .sr_video(minVideoTextBox.Text)
                .sr_RAM(Convert.ToUInt32(minRAMTextBox.Text))
                .sr_space(Convert.ToUInt32(minSpaceTextBox.Text))
                .Build();
            SystemReq maxSystemReq = new ReqBuilder()
                .idSystemReqType(2)
                .game(game)
                .sr_OS(maxOSTextBox.Text)
                .processor(maxProcTextBox.Text)
                .sr_video(maxVideoTextBox.Text)
                .sr_RAM(Convert.ToUInt32(maxRAMTextBox.Text))
                .sr_space(Convert.ToUInt32(maxSpaceTextBox.Text))
                .Build();
            
            Session.daoSystemReq.AddSystemReq(minSystemReq);
            Session.daoSystemReq.AddSystemReq(maxSystemReq);

            DialogResult result = MessageBox.Show(
                    "Игра добавлена",
                    "Добавлено",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.OK)
            {
                this.Close();
            }

            this.Close();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            if(Session.dbType == DBtype.MongoDB)
            {
                GameGenre genre = new GameGenre(addGenreTextBox.Text.ToString());
                if (genre != null)
                {
                    addedGenresLabel.Text += genre.genreName + " ";
                    listGenres.Add(genre);
                    addGenreTextBox.Text = "";
                }
            }
            else
            {
                GameGenre genre = Session.daoGame.GetGameGenreByName(addGenreTextBox.Text.ToString());

                if (genre != null)
                {
                    addedGenresLabel.Text += genre.genreName + " ";
                    listGenres.Add(genre);
                    addGenreTextBox.Text = "";
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                        "Жанр " + addGenreTextBox.Text + " не найден. Добавить его в базу?",
                        "Ошибка",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.DefaultDesktopOnly);

                    if (result == DialogResult.Yes)
                    {
                        Session.daoGame.AddGenreByName(addGenreTextBox.Text.ToString());
                        genre = new GameGenre(addGenreTextBox.Text.ToString());
                        addedGenresLabel.Text += genre.genreName + " ";
                        listGenres.Add(genre);
                        addGenreTextBox.Text = "";
                    }
                    else if (result == DialogResult.No)
                    {
                        addGenreTextBox.Text = "";
                    }
                }
            }
            
        }
    }
}
