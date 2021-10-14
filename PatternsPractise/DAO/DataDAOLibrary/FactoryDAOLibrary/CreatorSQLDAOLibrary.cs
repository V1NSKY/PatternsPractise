using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DAOLibrary.FactoryDAOLibrary
{
    class CreatorSQLDAOLibrary : CreatorDAOLibrary
    {
        public override IDAOLibrary FactoryMetod()
        {
            return new DAOLibrary();
        }
    }
}
