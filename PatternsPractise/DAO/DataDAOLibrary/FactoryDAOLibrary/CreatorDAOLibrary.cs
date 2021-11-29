namespace PatternsPractise.DAO.DAOLibrary.FactoryDAOLibrary
{
    abstract class CreatorDAOLibrary
    {
        public abstract IDAOLibrary FactoryMetod(DBtype dbType);
    }
}
