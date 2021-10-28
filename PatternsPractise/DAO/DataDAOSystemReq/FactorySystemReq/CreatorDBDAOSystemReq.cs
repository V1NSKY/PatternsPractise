using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DAOSystemReq.FactorySystemReq
{
    class CreatorDBDAOSystemReq : CreatorDAOSystemReq
    {
        private static DAOSystemReq daoSystemReq;
        public override IDAOSystemReq FactoryMetod(DBtype dbType)
        {
            switch (dbType)
            {
                case DBtype.MySQL:
                    if (daoSystemReq == null)
                    {
                        return new DAOSystemReq();
                    }
                    else
                    {
                        return daoSystemReq;
                    }
                case DBtype.MongoDB:
                    return null;
                default:
                    return null;
            }
        }
    }
}
