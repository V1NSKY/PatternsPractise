using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.FactoryDAOUser
{
    abstract class CreatorDAOUser
    {
        public abstract IDAOUser FactoryMetod(DBtype dbType);
    }
}
