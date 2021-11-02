using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.ObserverDAO
{
    public interface IObserverDAOUser
    {
        public void Update(IDAOUser daoUser);
    }
}
