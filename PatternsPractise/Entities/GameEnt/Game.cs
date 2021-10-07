using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.Entities
{
    public class Game
    {
        private List<GameGenre> gameGenres = new List<GameGenre>();
        private List<SystemReq> systemReqs;
        private String gameDeveloper = "";
        private String gamePublisher = "";    
        private String gameName = "";
        private float gamePrice = 0;
        private String dateOfRelease = "00.00.0000";
        private String gameDescription = "";
        public void AddGenre(GameGenre gameGenre)
        {
            gameGenres.Add(gameGenre);
        }
        public void AddSystemReq(SystemReq systemReq)
        {
            systemReqs.Add(systemReq);
        }

        public override string ToString()
        {
            String obj = "";
            foreach (GameGenre genre in gameGenres)
            {
                obj += genre.genreName + " ";
            }
            /*foreach (SystemReq req in systemReqs)
            {
                obj += " Системные требования ";
            }*/
            return obj + gameDeveloper + " " + gamePublisher + " " + gameName + " " + gamePrice.ToString() + " " + dateOfRelease + " " + gameDescription;
        }
        public class GameBuilder
        {
            Game game;
            public GameBuilder()
            {
                game = new Game();
            }
            public GameBuilder AddGenreBuilder(GameGenre gameGenre)
            {
                game.AddGenre(gameGenre);
                return this;
            }
            public GameBuilder AddSystemReqsBuilder(SystemReq systemReq)
            {
                game.AddSystemReq(systemReq);
                return this;
            }
            public GameBuilder gameDeveloper(String gameDeveloper)
            {
                game.gameDeveloper = gameDeveloper;
                return this;
            }
            public GameBuilder gamePublisher(String gamePublisher)
            {
                game.gamePublisher = gamePublisher;
                return this;
            }
            public GameBuilder gameName(String gameName)
            {
                game.gameName = gameName;
                return this;
            }
            public GameBuilder gamePrice(float gamePrice)
            {
                game.gamePrice = gamePrice;
                return this;
            }
            public GameBuilder gameDateOfRelease(String dateOfRelease)
            {
                game.dateOfRelease = dateOfRelease;
                return this;
            }
            public GameBuilder gameDescription (String gameDescription)
            {
                game.gameDescription = gameDescription;
                return this;
            }
            public Game Build()
            {
                return game;
            }
        }

    }
}
