using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DAOGame.FactoryDAOGame
{
    public abstract class CreatorDAOGame
    {
        public abstract IDAOGame FactoryMetod(DBtype dbType);
    }
}
