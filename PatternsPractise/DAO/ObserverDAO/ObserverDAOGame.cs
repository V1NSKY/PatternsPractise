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
