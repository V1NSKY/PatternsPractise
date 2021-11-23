using MongoDB.Bson;
using MongoDB.Driver;
using PatternsPractise.DAO.ObserverDAO;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DataDAOUser.FactoryDAOUser
{
    class DAOMongoUser : IDAOUser
    {
        private List<IObserverDAOUser> observers = new List<IObserverDAOUser>();
        public string AddUser(User user)
        {
            Random random = new Random();
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            var collection = database.GetCollection<User>("User");
            user.UserId = random.Next();
            collection.InsertOne(user);
            return "Inserted";
        }
        public string DeleteUser(int idUser)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            var collection = database.GetCollection<BsonDocument>("User");
            var filter = new BsonDocument("UserId", idUser);
            collection.DeleteOne(filter);
            return "Deleted";
        }

        public List<User> GetAllUsers()
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<User> collection = database.GetCollection<User>("User");
            FilterDefinition<User> filter = Builders<User>.Filter.Empty;
            return collection.Find<User>(filter).ToList<User>();
        }

        public User GetUserById(int idUser)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<User> collection = database.GetCollection<User>("User");
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("UserId", idUser);
            return collection.Find<User>(filter).ToList().LastOrDefault();
        }

        public int GetUserIdByCred(string login, string password)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<User> collection = database.GetCollection<User>("User");
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("UserLogin", login) & Builders<User>.Filter.Eq("UserPassword", password);
            User user = collection.Find<User>(filter).ToList().LastOrDefault();

            if (user != null)
            {
                return user.UserId;
            }
            else
            {
                return 0;
            }
        }

        public int GetUserIdByLogin(string login)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<User> collection = database.GetCollection<User>("User");
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("UserLogin", login);
            User user = collection.Find<User>(filter).ToList().LastOrDefault();

            if (user != null)
            {
                return user.UserId;
            }
            else
            {
                return 0;
            }
            
        }
        public List<User> SearchUsersByName(string userName)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<User> collection = database.GetCollection<User>("User");
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("UserName", userName);
            return collection.Find<User>(filter).ToList();
        }

        public string UpdateUser(User user)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<User> collection = database.GetCollection<User>("User");
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("UserId", user.UserId);
            collection.ReplaceOne(filter, user);
            Notify();
            return "Updated";
        }
        public void AddObserver(IObserverDAOUser observer)
        {
            observers.Add(observer);
        }
        public void DeleteObserver(IObserverDAOUser observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IObserverDAOUser observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
