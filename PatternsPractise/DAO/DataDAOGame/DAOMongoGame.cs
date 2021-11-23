using MongoDB.Bson;
using MongoDB.Driver;
using PatternsPractise.DAO.ObserverDAO;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DataDAOGame
{
    class DAOMongoGame : IDAOGame
    {
        private List<IObserverDAOGame> observers = new List<IObserverDAOGame>();
        public string AddGame(Game game)
        {
            Random random = new Random();
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            var collection = database.GetCollection<Game>("Game");
            game.GameId = random.Next();
            collection.InsertOne(game);
            Notify();
            return "Inserted";
        }
       
        public string DeleteGame(int idGame)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            var collection = database.GetCollection<BsonDocument>("Game");
            var filter = new BsonDocument("GameId", idGame);
            collection.DeleteOne(filter);
            Notify();
            return "Deleted";
        }

        public List<Game> GetAllGame()
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<Game> collection = database.GetCollection<Game>("Game");
            FilterDefinition<Game> filter = Builders<Game>.Filter.Empty;
            return collection.Find<Game>(filter).ToList<Game>();
        }

        public Game GetGameById(int idGame)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<Game> collection = database.GetCollection<Game>("Game");
            FilterDefinition<Game> filter = Builders<Game>.Filter.Eq("GameId", idGame);
            return collection.Find<Game>(filter).ToList().LastOrDefault();
        }

        public Game GetGameByName(string gameName)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<Game> collection = database.GetCollection<Game>("Game");
            FilterDefinition<Game> filter = Builders<Game>.Filter.Eq("GameName", gameName);
            return collection.Find<Game>(filter).ToList().LastOrDefault();
        }

        public List<GameGenre> GetGameGenres(int idGame)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<Game> collection = database.GetCollection<Game>("Game");
            FilterDefinition<Game> filter = Builders<Game>.Filter.Eq("GameId", idGame);
            return collection.Find<Game>(filter).ToList().LastOrDefault().GetGenres();
        }

       
        public List<Game> SearchGameByName(string gameName)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<Game> collection = database.GetCollection<Game>("Game");
            FilterDefinition<Game> filter = Builders<Game>.Filter.Eq("GameName", gameName);
            return collection.Find<Game>(filter).ToList();
        }

        public string UpdateGame(Game game)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<Game> collection = database.GetCollection<Game>("Game");
            FilterDefinition<Game> filter = Builders<Game>.Filter.Eq("GameId", game.GameId);
            collection.ReplaceOne(filter, game);
            Notify();
            return "Updated";
        }

        public void AddObserver(IObserverDAOGame observer)
        {
            observers.Add(observer);
        }
        public void DeleteObserver(IObserverDAOGame observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IObserverDAOGame observer in observers)
            {
                observer.Update();
            }
        }

        // not impl
        public string AddGenreByName(string genreName)
        {
            throw new NotImplementedException();
        }
        public GameGenre GetGameGenreByName(string genreName)
        {
            throw new NotImplementedException();
        }
    }
}
