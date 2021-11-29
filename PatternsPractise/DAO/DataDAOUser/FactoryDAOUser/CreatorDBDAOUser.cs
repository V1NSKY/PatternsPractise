using PatternsPractise.DAO.DataDAOUser.FactoryDAOUser;

namespace PatternsPractise.DAO.FactoryDAOUser
{
    class CreatorDBDAOUser : CreatorDAOUser
    {
        public override IDAOUser FactoryMetod(DBtype dbType)
        {
            switch (dbType)
            {
                case DBtype.MySQL:
                    return new DAOUser();
                case DBtype.MongoDB:
                    return new DAOMongoUser();
                default:
                    return null;
            }
        }
    }
}
