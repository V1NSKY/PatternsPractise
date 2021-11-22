using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsPractise.DAO.ObserverDAO
{
    class ObserverDAOGame : IObserverDAOGame
    {
        DataGridView _gridView;
        public ObserverDAOGame (DataGridView gridView)
        {
            _gridView = gridView;
        }
        public void Update()
        {
            _gridView.DataSource = Session.daoGame.GetAllGame();
        }
    }
}
