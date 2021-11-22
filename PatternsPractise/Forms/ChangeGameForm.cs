using PatternsPractise.DAO;
using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
using PatternsPractise.DAO.DAOSystemReq.FactorySystemReq;
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
using static PatternsPractise.Entities.Game;
using static PatternsPractise.Entities.SystemReq;

namespace PatternsPractise.Forms
{
    public partial class ChangeGameForm : Form
    {
        static private ChangeGameForm changeGameForm;
        List<GameGenre> gameGenres;
        List<SystemReq> systemReqs;
        Game game;
        private ChangeGameForm()
        {
            InitializeComponent();
        }
        public static ChangeGameForm GetChangeGameForm()
        {
            if(changeGameForm == null || changeGameForm.IsDisposed)
            {
                return changeGameForm = new ChangeGameForm();
            }
            else
            {
                return changeGameForm;
            }
        }

        private void ChangeGameForm_Load(object sender, EventArgs e)
        {
            game = Session.daoGame.GetGameById(Session.selectedGameid);
            addNameTextBox.Text = game.GameName;
            addDeveloperTextBox.Text = game.GameDeveloper;
            addPublisherTextBox.Text = game.GamePublisher;
            addPriceTextBox.Text = game.GamePrice.ToString();
            addDateOfRelease.Text = game.DateOfRelease;
            addDescriptionTextBox.Text = game.GameDescription;

            systemReqs = Session.daoSystemReq.GetSystemReqByGameId(game.GameId);

            foreach(SystemReq systemReq in systemReqs)
            {
                switch (systemReq.IdSystemReqType)
                {
                    case 1:
                        minOSTextBox.Text = systemReq.Sr_OS;
                        minProcTextBox.Text = systemReq.Processor;
                        minVideoTextBox.Text = systemReq.Sr_Video;
                        minRAMTextBox.Text = systemReq.Sr_RAM.ToString();
                        minSpaceTextBox.Text = systemReq.Sr_space.ToString();
                        break;
                    case 2:
                        maxOSTextBox.Text = systemReq.Sr_OS;
                        maxProcTextBox.Text = systemReq.Processor;
                        maxVideoTextBox.Text = systemReq.Sr_Video;
                        maxRAMTextBox.Text = systemReq.Sr_RAM.ToString();
                        maxSpaceTextBox.Text = systemReq.Sr_space.ToString();
                        break;
                }
            }

            gameGenres = Session.daoGame.GetGameGenres(game.GameId);
            game.GameGenre = gameGenres;

            foreach(GameGenre genre in gameGenres)
            {
                addedGenresLabel.Text += genre.genreName + " ";
            }
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            GameGenre genre = Session.daoGame.GetGameGenreByName(addGenreTextBox.Text.ToString());

            if (genre != null)
            {
                addedGenresLabel.Text += genre.genreName + " ";
                gameGenres.Add(genre);
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
                    gameGenres.Add(genre);
                    addGenreTextBox.Text = "";
                }
                else if (result == DialogResult.No)
                {
                    addGenreTextBox.Text = "";
                }
            }
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            Session.gameCaretaker.AddGameState(game.SaveGameState());
            Game newGame = new GameBuilder()
                .gameId(game.GameId)
                .listGenre(gameGenres)
                .gameName(addNameTextBox.Text.ToString())
                .gameDeveloper(addDeveloperTextBox.Text.ToString())
                .gamePublisher(addPublisherTextBox.Text.ToString())
                .gamePrice(Convert.ToDouble(addPriceTextBox.Text))
                .gameDateOfRelease(addDateOfRelease.Text.ToString())
                .gameDescription(addDescriptionTextBox.Text.ToString())
                .Build();

            foreach (SystemReq systemReq in systemReqs)
            {
                switch (systemReq.IdSystemReqType)
                {
                    case 1:
                        SystemReq minSystemReq = new ReqBuilder()
                            .idSystemReq(systemReq.IdSystemReq)
                            .idSystemReqType(1)
                            .game(newGame)
                            .sr_OS(minOSTextBox.Text)
                            .processor(minProcTextBox.Text)
                            .sr_video(minVideoTextBox.Text)
                            .sr_RAM(Convert.ToUInt32(minRAMTextBox.Text))
                            .sr_space(Convert.ToUInt32(minSpaceTextBox.Text))
                            .Build();
                        Session.daoSystemReq.UpdateSystemReq(minSystemReq);
                        break;
                    case 2:
                        SystemReq maxSystemReq = new ReqBuilder()
                            .idSystemReq(systemReq.IdSystemReq)
                            .idSystemReqType(2)
                            .game(newGame)
                            .sr_OS(maxOSTextBox.Text)
                            .processor(maxProcTextBox.Text)
                            .sr_video(maxVideoTextBox.Text)
                            .sr_RAM(Convert.ToUInt32(maxRAMTextBox.Text))
                            .sr_space(Convert.ToUInt32(maxSpaceTextBox.Text))
                            .Build();
                        Session.daoSystemReq.UpdateSystemReq(maxSystemReq);
                        break;
                }
            }
            
        
            Session.daoGame.UpdateGame(newGame);

            DialogResult result = MessageBox.Show(
                   "Игра изменена",
                   "Изменено",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1
                   );

            if (result == DialogResult.OK)
            {
                this.Close();
            }

            this.Close();
        }
    }

}
