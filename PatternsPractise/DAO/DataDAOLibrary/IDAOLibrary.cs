using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsPractise.Entities;

namespace PatternsPractise.DAO
{
    interface IDAOLibrary
    {
        public String AddLibrary(UserGameLibrary userGameLibrary);
        public String DeleteLibrary(int idUser);
        public int DeleteLibraryGame(int idGame);
        public List<UserGameLibrary> GetAllUserLibrary(int idUser);

    }
}
