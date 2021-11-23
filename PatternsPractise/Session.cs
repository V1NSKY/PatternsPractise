using PatternsPractise.Entities;
using static PatternsPractise.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
using PatternsPractise.DAO.FactoryDAOUser;
using PatternsPractise.DAO;
using PatternsPractise.DAO.DAOLibrary.FactoryDAOLibrary;
using PatternsPractise.Entities.GameEnt;

namespace PatternsPractise
{
    public static class Session
    {
        public static GameCaretaker gameCaretaker;
        public static IDAOGame daoGame;
        public static IDAOUser daoUser;
        public static IDAOLibrary daoLibrary;
        public static IDAOSystemReq daoSystemReq;
        public static DBtype dbType;
        public static User user { private set; get; }
        public static int selectedGameid { get; set; }
        public static Form mainMenu { set; get; }
        public static void SetUser(User newUser)
        {
            user = newUser;
        }
        public static User GetUser(User newUser)
        {
                return user;
        }
        public static void NullUser()
        {
            user = null;
        }
    }
}
