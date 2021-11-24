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
            user.UserId = new Random().Next();
            Connection.Connection.GetMongoDataBase().GetCollection<User>("User").InsertOne(user);
            return "Inserted";
        }
        public string DeleteUser(int idUser)
        {
            Connection.Connection.GetMongoDataBase().GetCollection<BsonDocument>("User").DeleteOne(new BsonDocument("UserId", idUser));
            return "Deleted";
        }

        public List<User> GetAllUsers()
        {
            return Connection.Connection.GetMongoDataBase().GetCollection<User>("User").Find<User>(Builders<User>.Filter.Empty).ToList<User>();
        }

        public User GetUserById(int idUser)
        {
            return Connection.Connection.GetMongoDataBase().GetCollection<User>("User").Find<User>(Builders<User>.Filter.Eq("UserId", idUser)).ToList().LastOrDefault();
        }

        public int GetUserIdByCred(string login, string password)
        {
            User user = Connection.Connection.GetMongoDataBase().GetCollection<User>("User").Find<User>(Builders<User>.Filter.Eq("UserLogin", login) & Builders<User>.Filter.Eq("UserPassword", password)).ToList().LastOrDefault();

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
            User user = Connection.Connection.GetMongoDataBase().GetCollection<User>("User").Find<User>(Builders<User>.Filter.Eq("UserLogin", login)).ToList().LastOrDefault();

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
            return Connection.Connection.GetMongoDataBase().GetCollection<User>("User").Find<User>(Builders<User>.Filter.Eq("UserName", userName)).ToList();
        }

        public string UpdateUser(User user)
        {
            Connection.Connection.GetMongoDataBase().GetCollection<User>("User").ReplaceOne(Builders<User>.Filter.Eq("UserId", user.UserId), user);
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
