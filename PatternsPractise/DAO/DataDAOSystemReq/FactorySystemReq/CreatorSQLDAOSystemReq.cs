using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DAOSystemReq.FactorySystemReq
{
    class CreatorSQLDAOSystemReq : CreatorDAOSystemReq
    {
        public override IDAOSystemReq FactoryMetod()
        {
            return new DAOSystemReq();
        }
    }
}
