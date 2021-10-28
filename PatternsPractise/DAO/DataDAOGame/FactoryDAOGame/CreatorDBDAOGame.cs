using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DAOGame.FactoryDAOGame
{
    class CreatorDBDAOGame : CreatorDAOGame
    {
        private static IDAOGame daoGame;
        public override IDAOGame FactoryMetod(DBtype dbType)
        {
            switch (dbType)
            {
                case DBtype.MySQL:
                    if(daoGame == null)
                    {
                        return new DAOGame();
                    }
                    else
                    {
                        return daoGame;
                    }
                case DBtype.MongoDB:
                    return null;
                default: 
                    return null;     
            }
        }
    }
}
