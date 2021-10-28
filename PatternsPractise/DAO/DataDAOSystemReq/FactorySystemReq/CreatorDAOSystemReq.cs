using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DAOSystemReq.FactorySystemReq
{
    abstract class CreatorDAOSystemReq
    {
        public abstract IDAOSystemReq FactoryMetod(DBtype dbType);
    }
}
