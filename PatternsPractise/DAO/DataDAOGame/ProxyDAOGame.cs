using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
using PatternsPractise.DAO.ObserverDAO;
using PatternsPractise.Entities;

namespace PatternsPractise.DAO.DataDAOGame
{
    class ProxyDAOGame:IDAOGame
    {
        private IDAOGame realDaoGame;

        public ProxyDAOGame(IDAOGame daoGame)
        {
            this.realDaoGame = daoGame;
        }
        private void ShowError()
        {
            MessageBox.Show(
                "Доступ запрещён\n User role = " + Session.user.UserRole,
                "Ошибка доступа",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1
            );
        }
        public void TruncateGame()
        {
            if (Session.user.UserRole == UserRole.Admin)
            {
                realDaoGame.TruncateGame();
            }
            else
            {
                ShowError();
            }
        }

        public string AddGame(Game game)
        {
            if (Session.user.UserRole == UserRole.Admin)
            {
                return realDaoGame.AddGame(game);
            }
            else
            {
                ShowError();
                return "";
            }
        }

        public string AddGenreByName(string genreName)
        {
            if (Session.user.UserRole == UserRole.Admin)
            {
                return realDaoGame.AddGenreByName(genreName);
            }
            else
            {
                ShowError();
                return "";
            }
        }

        public string DeleteGame(int idGame)
        {
            if (Session.user.UserRole == UserRole.Admin)
            {
                return realDaoGame.DeleteGame(idGame);
            }
            else
            {
                ShowError();
                return "";
            }
        }

        public string UpdateGame(Game game)
        {
            if (Session.user.UserRole == UserRole.Admin)
            {
                return realDaoGame.UpdateGame(game);
            }
            else
            {
                ShowError();
                return "";
            }
        }

        public List<Game> SearchGameByName(string gameName)
        {
            return realDaoGame.SearchGameByName(gameName);
        }

        public List<Game> GetAllGame()
        {
            return realDaoGame.GetAllGame();
        }

        public Game GetGameById(int idGame)
        {
            return realDaoGame.GetGameById(idGame);
        }

        public Game GetGameByName(string gameName)
        {
            return realDaoGame.GetGameByName(gameName);
        }

        public List<GameGenre> GetGameGenres(int idGame)
        {
            return realDaoGame.GetGameGenres(idGame);
        }

        public GameGenre GetGameGenreByName(string genreName)
        {
            return realDaoGame.GetGameGenreByName(genreName);
        }

        public void AddObserver(IObserverDAOGame observer)
        {
            realDaoGame.AddObserver(observer);
        }

        public void DeleteObserver(IObserverDAOGame observer)
        {
            realDaoGame.DeleteObserver(observer);
        }

        public void Notify()
        {
            realDaoGame.Notify();
        }
    }
}
