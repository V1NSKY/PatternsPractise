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

namespace PatternsPractise.Forms
{
    public partial class GameInfoForm : Form
    {
        public GameInfoForm()
        {
            InitializeComponent();
        }

        private void GameInfoForm_Load(object sender, EventArgs e)
        {
            CreatorDAOGame creatorDAOGame = new CreatorSQLDAOGame();
            IDAOGame daoGame = creatorDAOGame.FactoryMetod();
            CreatorDAOSystemReq creatorDAOSystemReq = new CreatorSQLDAOSystemReq();
            IDAOSystemReq daoSystemReq = creatorDAOSystemReq.FactoryMetod();

            Game game = daoGame.GetGameById(Session.selectedGameid);

            nameLabel.Text = game.GameName.ToUpper().ToString();
            developerLabel.Text = game.GameDeveloper.ToString();
            publisherLabel.Text = game.GamePublisher.ToString();
            priceLabel.Text = game.GamePrice.ToString();
            dateOfReleaseLabel.Text = game.DateOfRelease.ToString();
            descriptionLabel.Text = game.GameDescription;

            List<SystemReq> systemReqs = daoSystemReq.GetSystemReqByGameId(game.GameId);

            foreach(SystemReq req in systemReqs)
            {
                switch (req.IdSystemReqType)
                {
                    case 2:
                        minOSLabel.Text = req.Sr_OS;
                        minProcLabel.Text = req.Processor;
                        minRAMLabel.Text = req.Sr_RAM.ToString();
                        minSpaceLabel.Text = req.Sr_space.ToString();
                        minVideoLabel.Text = req.Sr_Video;
                        break;
                    case 1:
                        recOSLabel.Text = req.Sr_OS;
                        recProcLabel.Text = req.Processor;
                        recRamLabel.Text = req.Sr_RAM.ToString();
                        recSpaceLabel.Text = req.Sr_space.ToString();
                        recVideoLabel.Text = req.Sr_Video;
                        break;
                }
            }
        }
    }
}
