using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternsPractise.DAO.ObserverDAO
{
    public interface IObserverDAOGame
    {
        public void Update(IDAOGame daoGame);
    }
}
