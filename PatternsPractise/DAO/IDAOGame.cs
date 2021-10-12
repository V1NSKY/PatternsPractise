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
        public String AddGame(Game game);
        public String DeleteGame(int idGame);
        public String UpdateGame(Game game);
        public List<Game> SearchGameByName(String gameName);
        public List<Game> GetAllGame();
        public Game GetGameById(int idGame);
    }
}
