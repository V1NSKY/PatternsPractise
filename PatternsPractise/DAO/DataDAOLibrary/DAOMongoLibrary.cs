using MongoDB.Bson;
using MongoDB.Driver;
using PatternsPractise.DAO.ObserverDAO;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DataDAOLibrary
{
    class DAOMongoLibrary : IDAOLibrary
    {
        private List<IObserverDAOGameLibrary> observers = new List<IObserverDAOGameLibrary>();
        public string AddLibrary(UserGameLibrary userGameLibrary)
        {
            List<UserGameLibrary> libraries = GetAllUserLibrary(userGameLibrary.User.UserId);
            if(libraries != null)
            {
                foreach (UserGameLibrary library in libraries)
                {
                    if (userGameLibrary.Game.GameId == library.Game.GameId)
                    {
                        return "Игра уже есть в библиотеке";
                    }
                }
            }

            userGameLibrary.DateAdded = DateTime.Today.ToString();
            userGameLibrary.DateLastPlayed = DateTime.Today.ToString();

            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            var collection = database.GetCollection<UserGameLibrary>("GameLibrary");
            collection.InsertOne(userGameLibrary);
            return "Игра добавлена в библиотеку";
        }
        public string DeleteLibrary(int idUser)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            var collection = database.GetCollection<BsonDocument>("GameLibrary");
            var filter = new BsonDocument("User.UserId", idUser);
            collection.DeleteOne(filter);
            return "Deleted";
        }
        public int DeleteLibraryGame(int idGame)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            var collection = database.GetCollection<BsonDocument>("GameLibrary");
            var filter = new BsonDocument("Game.GameId", idGame);
            collection.DeleteOne(filter);
            Notify();
            return 1;
        }
        public List<UserGameLibrary> GetAllUserLibrary(int idUser)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<UserGameLibrary> collection = database.GetCollection<UserGameLibrary>("GameLibrary");
            FilterDefinition<UserGameLibrary> filter = Builders<UserGameLibrary>.Filter.Eq("User.UserId", idUser);
            return collection.Find<UserGameLibrary>(filter).ToList<UserGameLibrary>();
        }
        public void AddObserver(IObserverDAOGameLibrary observer)
        {
            observers.Add(observer);
        }
        public void DeleteObserver(IObserverDAOGameLibrary observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IObserverDAOGameLibrary observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
