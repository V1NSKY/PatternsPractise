using PatternsPractise.DAO.DataDAOSystemReq;

namespace PatternsPractise.DAO.DAOSystemReq.FactorySystemReq
{
    class CreatorDBDAOSystemReq : CreatorDAOSystemReq
    {
        public override IDAOSystemReq FactoryMetod(DBtype dbType)
        {
            switch (dbType)
            {
                case DBtype.MySQL:
                    return new DAOSystemReq();
                case DBtype.MongoDB:
                    return new DAOMongoSystemReq();
                default:
                    return null;
            }
        }
    }
}
