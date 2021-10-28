using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.FactoryDAOUser
{
    class CreatorDBDAOUser : CreatorDAOUser
    {
        DAOUser daoUser;
        public override IDAOUser FactoryMetod(DBtype dbType)
        {
            switch (dbType)
            {
                case DBtype.MySQL:
                    if (daoUser == null)
                    {
                        return new DAOUser();
                    }
                    else
                    {
                        return daoUser;
                    }
                case DBtype.MongoDB:
                    return null;
                default:
                    return null;
            }
        }
    }
}
