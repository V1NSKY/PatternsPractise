using PatternsPractise.DAO.DataDAOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
