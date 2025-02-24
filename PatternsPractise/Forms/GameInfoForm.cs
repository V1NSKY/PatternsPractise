﻿using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PatternsPractise.Forms
{
    public partial class GameInfoForm : Form
    {
        static private GameInfoForm gameInfoForm;
        private GameInfoForm()
        {
            InitializeComponent();
        }
        public static GameInfoForm GetGameInfoForm()
        {
            if(gameInfoForm == null || gameInfoForm.IsDisposed)
            {
                return gameInfoForm = new GameInfoForm();
            }
            else
            {
                return gameInfoForm;
            }
        }

        private void GameInfoForm_Load(object sender, EventArgs e)
        {
            Game game = Session.daoGame.GetGameById(Session.selectedGameid);

            List<GameGenre> gameGenres = Session.daoGame.GetGameGenres(Session.selectedGameid);

            for(int i = 0; i < gameGenres.Count; i++)
            {
                game.AddGenre(gameGenres[i]);
                if(i == gameGenres.Count - 1)
                {
                    ganreLabel.Text += gameGenres[i].genreName + ".";
                }
                else
                {
                    ganreLabel.Text += gameGenres[i].genreName + ", ";
                }
                
            }
            

            nameLabel.Text = game.GameName.ToUpper().ToString();
            developerLabel.Text = game.GameDeveloper.ToString();
            publisherLabel.Text = game.GamePublisher.ToString();
            priceLabel.Text = game.GamePrice.ToString();
            dateOfReleaseLabel.Text = game.DateOfRelease.ToString();
            descriptionLabel.Text = game.GameDescription;

            List<SystemReq> systemReqs = Session.daoSystemReq.GetSystemReqByGameId(game.GameId);

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
