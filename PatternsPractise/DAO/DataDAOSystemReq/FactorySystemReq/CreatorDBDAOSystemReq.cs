using PatternsPractise.DAO.DataDAOSystemReq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
