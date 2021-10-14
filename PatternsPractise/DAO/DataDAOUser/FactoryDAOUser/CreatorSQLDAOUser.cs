using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.FactoryDAOUser
{
    class CreatorSQLDAOUser : CreatorDAOUser
    {
        public override IDAOUser FactoryMetod()
        {
            return new DAOUser();
        }
    }
}
