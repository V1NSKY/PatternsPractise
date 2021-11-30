using MongoDB.Bson;
using MongoDB.Driver;
using PatternsPractise.DAO.ObserverDAO;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PatternsPractise.DAO.DataDAOGame
{
    class DAOMongoGame : IDAOGame
    {
        private List<IObserverDAOGame> observers = new List<IObserverDAOGame>();
        public string AddGame(Game game)
        {
            if(game.GameId == 0)
            {
                game.GameId = new Random().Next();
            }
            Connection.Connection.GetMongoDataBase().GetCollection<Game>("Game").InsertOne(game);
            Notify();
            return "Inserted";
        }
       
        public string DeleteGame(int idGame)
        {
            Connection.Connection.GetMongoDataBase().GetCollection<BsonDocument>("Game").DeleteOne(new BsonDocument("GameId", idGame));
            Notify();
            return "Deleted";
        }

        public List<Game> GetAllGame()
        {
            return Connection.Connection.GetMongoDataBase().GetCollection<Game>("Game").Find<Game>(Builders<Game>.Filter.Empty).ToList<Game>();
        }

        public Game GetGameById(int idGame)
        {
            return Connection.Connection.GetMongoDataBase().GetCollection<Game>("Game").Find<Game>(Builders<Game>.Filter.Eq("GameId", idGame)).ToList().LastOrDefault();
        }

        public Game GetGameByName(string gameName)
        {
            return Connection.Connection.GetMongoDataBase().GetCollection<Game>("Game").Find<Game>(Builders<Game>.Filter.Eq("GameName", gameName)).ToList().LastOrDefault();
        }

        public List<GameGenre> GetGameGenres(int idGame)
        {
            return Connection.Connection.GetMongoDataBase().GetCollection<Game>("Game").Find<Game>(Builders<Game>.Filter.Eq("GameId", idGame)).ToList().LastOrDefault().GetGenres();
        }

       
        public List<Game> SearchGameByName(string gameName)
        {
            return Connection.Connection.GetMongoDataBase().GetCollection<Game>("Game").Find<Game>(Builders<Game>.Filter.Eq("GameName", gameName)).ToList();
        }

        public string UpdateGame(Game game)
        {
            Connection.Connection.GetMongoDataBase().GetCollection<Game>("Game").ReplaceOne(Builders<Game>.Filter.Eq("GameId", game.GameId), game);
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
        public void TruncateGame()
        {
            var db = Connection.Connection.GetMongoDataBase();
                db.DropCollection("Game");
                db.CreateCollection("Game");
                db.GetCollection<Game>("Game").Indexes
                    .CreateOne(new CreateIndexModel<Game>(Builders<Game>.IndexKeys.Ascending(game => game.GameId), new CreateIndexOptions() { Unique = true }));
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
