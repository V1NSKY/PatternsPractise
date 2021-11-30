using PatternsPractise.DAO.ObserverDAO;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;

namespace PatternsPractise.DAO
{
    public interface IDAOUser
    {
        public void TruncateUser();
        public List<User> GetAllUsers();
        public List<User> SearchUsersByName(String userName);
        public List<User> SearchUsersByNameAndPassword(String userName, String password);
        public String AddUser(User user);
        public String DeleteUser(int idUser);
        public int DeleteUserByName(String name);
        public String UpdateUser(User user);
        public User GetUserById(int idUser);
        public int GetUserIdByCred(String login, String password);
        public int GetUserIdByLogin(String login);
        public void AddObserver(IObserverDAOUser observer);
        public void DeleteObserver(IObserverDAOUser observer);
        public void Notify();
    }
}
