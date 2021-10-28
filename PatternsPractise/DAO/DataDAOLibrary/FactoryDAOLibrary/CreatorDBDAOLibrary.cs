using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DAOLibrary.FactoryDAOLibrary
{
    class CreatorDBDAOLibrary : CreatorDAOLibrary
    {
        private static DAOLibrary daoLibrary;
        public override IDAOLibrary FactoryMetod(DBtype dbType)
        {
            switch (dbType)
            {
                case DBtype.MySQL:
                    if (daoLibrary == null)
                    {
                        return new DAOLibrary();
                    }
                    else
                    {
                        return daoLibrary;
                    }
                case DBtype.MongoDB:
                    return null;
                default:
                    return null;
            }
        }
    }
}
