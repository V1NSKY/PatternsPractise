using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
using PatternsPractise.DAO.DAOLibrary.FactoryDAOLibrary;
using PatternsPractise.DAO.DAOSystemReq.FactorySystemReq;
using PatternsPractise.DAO.FactoryDAOUser;
using PatternsPractise.Entities;
using System.Collections.Generic;

namespace PatternsPractise.DAO.MigrationMetod
{
    public static class Migration
    {
        public static IDAOGame daoGameSQL = new CreatorDBDAOGame().FactoryMetod(DBtype.MySQL);
        public static IDAOUser daoUserSQL = new CreatorDBDAOUser().FactoryMetod(DBtype.MySQL);
        public static IDAOLibrary daoLibrarySQL = new CreatorDBDAOLibrary().FactoryMetod(DBtype.MySQL);
        public static IDAOSystemReq daoSysReqSQL = new CreatorDBDAOSystemReq().FactoryMetod(DBtype.MySQL);
        public static IDAOGame daoGameMongo = new CreatorDBDAOGame().FactoryMetod(DBtype.MongoDB);
        public static IDAOUser daoUserMongo = new CreatorDBDAOUser().FactoryMetod(DBtype.MongoDB);
        public static IDAOLibrary daoLibraryMongo = new CreatorDBDAOLibrary().FactoryMetod(DBtype.MongoDB);
        public static IDAOSystemReq daoSysReqMongo = new CreatorDBDAOSystemReq().FactoryMetod(DBtype.MongoDB);

        public static void Migrate_SQL_To_MongoBD()
        {
            List<Game> listGames = daoGameSQL.GetAllGame();
            List<SystemReq> listSysReq = daoSysReqSQL.GetAllSystemReq();
            List<User> listUser = daoUserSQL.GetAllUsers();
            
            
            foreach (Game game in listGames)
            {
                game.GameGenre = daoGameSQL.GetGameGenres(game.GameId);
                foreach(SystemReq systemReq in listSysReq)
                {
                    if(systemReq.Game.GameId == game.GameId)
                    {
                        systemReq.Game = game;
                        daoSysReqMongo.AddSystemReq(systemReq);
                    }
                }
                daoGameMongo.AddGame(game);
            }
            foreach(User user in listUser)
            {
                List<UserGameLibrary> listLibrary = daoLibrarySQL.GetAllUserLibrary(user.UserId);
                if(listLibrary != null)
                {
                    foreach (UserGameLibrary library in listLibrary)
                    {
                        foreach (Game game in listGames)
                        {
                            if (library.Game.GameId == game.GameId)
                            {
                                library.Game = game;
                            }
                        }
                        library.User = user;
                        daoLibraryMongo.AddLibrary(library);
                    }
                }
                daoUserMongo.AddUser(user);
            }
            
        }

        public static void Migrate_MongoDB_To_SQL()
        {
            List<Game> listGames = daoGameMongo.GetAllGame();
            List<SystemReq> listSysReq = daoSysReqMongo.GetAllSystemReq();
            List<User> listUser = daoUserMongo.GetAllUsers();
            foreach (Game game in listGames)
            {
                List<GameGenre> genres = daoGameMongo.GetGameGenres(game.GameId);
                foreach (var genre in genres)
                {
                    daoGameSQL.AddGenreByName(genre.genreName);
                }

                game.GameGenre = genres;
                daoGameSQL.AddGame(game);
                foreach (SystemReq systemReq in listSysReq)
                {
                    if (systemReq.Game.GameId == game.GameId)
                    {
                        systemReq.Game = game;
                        daoSysReqSQL.AddSystemReq(systemReq);
                    }
                }
            }
            foreach (User user in listUser)
            {
                daoUserSQL.AddUser(user);
                List<UserGameLibrary> listLibrary = daoLibraryMongo.GetAllUserLibrary(user.UserId);
                if (listLibrary != null)
                {
                    foreach (UserGameLibrary library in listLibrary)
                    {
                        foreach (Game game in listGames)
                        {
                            if (library.Game.GameId == game.GameId)
                            {
                                library.Game = game;
                            }
                        }
                        library.User = user;
                        daoLibrarySQL.AddLibrary(library);
                    }
                }
            }
        }
    }
}
