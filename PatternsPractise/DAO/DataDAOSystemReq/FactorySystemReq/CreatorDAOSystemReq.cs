namespace PatternsPractise.DAO.DAOSystemReq.FactorySystemReq
{
    abstract class CreatorDAOSystemReq
    {
        public abstract IDAOSystemReq FactoryMetod(DBtype dbType);
    }
}
