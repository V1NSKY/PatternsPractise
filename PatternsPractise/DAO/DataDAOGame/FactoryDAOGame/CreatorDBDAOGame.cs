using PatternsPractise.DAO.DataDAOGame;

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
                    return new DAOMongoGame();
                default: 
                    return null;     
            }
        }
    }
}
