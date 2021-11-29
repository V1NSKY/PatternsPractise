using PatternsPractise.DAO.ObserverDAO;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;

namespace PatternsPractise.DAO
{
    public interface IDAOGame
    {
        public String AddGame(Game game);
        public String AddGenreByName(String genreName);
        public String DeleteGame(int idGame);
        public String UpdateGame(Game game);
        public List<Game> SearchGameByName(String gameName);
        public List<Game> GetAllGame();
        public Game GetGameById(int idGame);
        public Game GetGameByName(String gameName);

        public List<GameGenre> GetGameGenres(int idGame);
        public GameGenre GetGameGenreByName(String genreName);
        public void AddObserver(IObserverDAOGame observer);
        public void DeleteObserver(IObserverDAOGame observer);
        public void Notify();
    }
}
