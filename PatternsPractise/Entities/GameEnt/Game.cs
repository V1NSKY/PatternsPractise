using MongoDB.Bson.Serialization.Attributes;
using PatternsPractise.Entities.GameEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.Entities
{
    [BsonIgnoreExtraElements]
    public class Game
    {
        private int gameId;
        private List<GameGenre> gameGenres = new List<GameGenre>();
        private String gameDeveloper = "";
        private String gamePublisher = "";
        private String gameName = "";
        private double gamePrice = 0;
        private String dateOfRelease = "0000.00.00";
        private String? gameDescription = "";

        private Game() { }
        public GameMemento SaveGameState()
        {
            return new GameMemento(this);
        }
        public void RestoreGameState(GameMemento memento)
        {
            this.GameId = memento.GetGameState().GameId;
            this.gameGenres = memento.GetGameState().gameGenres;
            this.gameDeveloper = memento.GetGameState().gameDeveloper;
            this.gamePublisher = memento.GetGameState().gamePublisher;
            this.gameName = memento.GetGameState().gameName;
            this.gamePrice = memento.GetGameState().gamePrice;
            this.dateOfRelease = memento.GetGameState().dateOfRelease;
            this.gameDescription = memento.GetGameState().gameDescription;
        }
        public int GameId
        {
            get
            {
                return gameId;
            }
            set
            {
                gameId = value;
            }
        }
        public List<GameGenre> GameGenre
        {
            get
            {
                return gameGenres;
            }
            set
            {
                gameGenres = value;
            }
        }
        public String GameDeveloper
        {
            get
            {
                return gameDeveloper;
            }
            private set
            {
                gameDeveloper = value;
            }
        }
        public String GamePublisher
        {
            get
            {
                return gamePublisher;
            }
            private set
            {
                gamePublisher = value;
            }
        }
        public String GameName
        {
            get
            {
                return gameName;
            }
            private set
            {
                gameName = value;
            }
        }
        public double GamePrice
        {
            get
            {
                return gamePrice;
            }
            private set
            {
                gamePrice = value;
            }
        }
        public String DateOfRelease
        {
            get
            {
                return dateOfRelease;
            }
            private set
            {
                dateOfRelease = value;
            }
        }
        public String GameDescription
        {
            get
            {
                return gameDescription;
            }
            private set
            {
                gameDescription = value;
            }
        }

        public void AddGenre(GameGenre gameGenre)
        {
            gameGenres.Add(gameGenre);
        }
        public List<GameGenre> GetGenres ()
        {
            return this.gameGenres;
        }

        public override string ToString()
        {
            String obj = "";
            foreach (GameGenre genre in gameGenres)
            {
                obj += genre.ToString() + " ";
            }
            return obj + gameDeveloper + " " + gamePublisher + " " + gameName + " " + gamePrice.ToString() + " " + dateOfRelease + " " + gameDescription;
        }
        public class GameBuilder
        {
            readonly Game game;
            public GameBuilder()
            {
                game = new Game();
            }
            public GameBuilder gameId(int gameId)
            {
                game.gameId = gameId;
                return this;
            }
            public GameBuilder listGenre(List<GameGenre> listGameGenre)
            {
                game.gameGenres = listGameGenre;
                return this;
            }
            public GameBuilder AddGenreBuilder(GameGenre gameGenre)
            {
                game.AddGenre(gameGenre);
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
            public GameBuilder gamePrice(double gamePrice)
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
