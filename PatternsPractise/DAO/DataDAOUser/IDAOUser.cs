using PatternsPractise.DAO.ObserverDAO;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO
{
    public interface IDAOUser
    {
        public List<User> GetAllUsers();
        public List<User> SearchUsersByName(String userName);
        public String AddUser(User user);
        public String DeleteUser(int idUser);
        public String UpdateUser(User user);
        public User GetUserById(int idUser);
        public int GetUserIdByCred(String login, String password);
        public int GetUserIdByLogin(String login);
        public void AddObserver(IObserverDAOUser observer);
        public void DeleteObserver(IObserverDAOUser observer);
        public void Notify();
    }
}
