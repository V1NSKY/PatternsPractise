using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DAOLibrary.FactoryDAOLibrary
{
    abstract class CreatorDAOLibrary
    {
        public abstract IDAOLibrary FactoryMetod();
    }
}
