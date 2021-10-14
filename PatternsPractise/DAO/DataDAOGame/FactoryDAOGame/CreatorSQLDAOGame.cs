using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DAOGame.FactoryDAOGame
{
    class CreatorSQLDAOGame : CreatorDAOGame
    {
        public override IDAOGame FactoryMetod()
        {
            return new DAOGame();
        }
    }
}
