using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO
{
    interface IDAOGame
    {
        public String addGame(Game game);
        public void deleteGame(int idGame);
        public void updateGame(int idGame);
        public void searchGameByName(String gameName);
        public List<Game> GetAllGame();
    }
}
