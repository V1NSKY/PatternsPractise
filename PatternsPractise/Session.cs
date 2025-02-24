﻿using PatternsPractise.Entities;
using System.Windows.Forms;
using PatternsPractise.DAO;
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

        public static void NullUser()
        {
            user = null;
        }
    }
}
