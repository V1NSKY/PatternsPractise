using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsPractise.DAO.ObserverDAO
{
    class ObserverDAOLibrary : IObserverDAOGameLibrary
    {
        DataGridView dataGridView;
        public ObserverDAOLibrary(DataGridView _dataGridView) { dataGridView = _dataGridView; }
        public void Update(IDAOLibrary daoLibrary)
        {
            List<UserGameLibrary> userGames = new List<UserGameLibrary>();
            userGames = Session.daoLibrary.GetAllUserLibrary(Session.user.UserId);

            if (userGames != null)
            {
                foreach (UserGameLibrary library in userGames)
                {
                    library.Game = Session.daoGame.GetGameById(library.Game.GameId);
                }
                dataGridView.DataSource = userGames;
            }

        }
    }
}
