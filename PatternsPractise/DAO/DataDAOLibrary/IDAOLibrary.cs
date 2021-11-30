using System;
using System.Collections.Generic;
using PatternsPractise.DAO.ObserverDAO;
using PatternsPractise.Entities;

namespace PatternsPractise.DAO
{
    public interface IDAOLibrary
    {
        public void TruncateLibrary();
        public String AddLibrary(UserGameLibrary userGameLibrary);
        public String DeleteLibrary(int idUser);
        public int DeleteLibraryGame(int idGame);
        public List<UserGameLibrary> GetAllUserLibrary(int idUser);
        public void AddObserver(IObserverDAOGameLibrary observer);
        public void DeleteObserver(IObserverDAOGameLibrary observer);
        public void Notify();

    }
}
