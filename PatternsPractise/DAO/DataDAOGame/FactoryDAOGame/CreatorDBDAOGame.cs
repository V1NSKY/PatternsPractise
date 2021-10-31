using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DAOGame.FactoryDAOGame
{
    class CreatorDBDAOGame : CreatorDAOGame
    {
        public override IDAOGame FactoryMetod(DBtype dbType)
        {
            switch (dbType)
            {
                case DBtype.MySQL:
                    return new DAOGame();
                case DBtype.MongoDB:
                    return null;
                default: 
                    return null;     
            }
        }
    }
}
