using PatternsPractise.DAO.DataDAOLibrary;

namespace PatternsPractise.DAO.DAOLibrary.FactoryDAOLibrary
{
    class CreatorDBDAOLibrary : CreatorDAOLibrary
    {
        public override IDAOLibrary FactoryMetod(DBtype dbType)
        {
            switch (dbType)
            {
                case DBtype.MySQL:
                    return new DAOLibrary();
                case DBtype.MongoDB:
                    return new DAOMongoLibrary();
                default:
                    return null;
            }
        }
    }
}
