using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    return null;
                default:
                    return null;
            }
        }
    }
}
