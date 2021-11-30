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
        private static IDAOGame daoGameSQL = new CreatorDBDAOGame().FactoryMetod(DBtype.MySQL);
        private static IDAOUser daoUserSQL = new CreatorDBDAOUser().FactoryMetod(DBtype.MySQL);
        private static IDAOLibrary daoLibrarySQL = new CreatorDBDAOLibrary().FactoryMetod(DBtype.MySQL);
        private static IDAOSystemReq daoSysReqSQL = new CreatorDBDAOSystemReq().FactoryMetod(DBtype.MySQL);
        private static IDAOGame daoGameMongo = new CreatorDBDAOGame().FactoryMetod(DBtype.MongoDB);
        private static IDAOUser daoUserMongo = new CreatorDBDAOUser().FactoryMetod(DBtype.MongoDB);
        private static IDAOLibrary daoLibraryMongo = new CreatorDBDAOLibrary().FactoryMetod(DBtype.MongoDB);
        private static IDAOSystemReq daoSysReqMongo = new CreatorDBDAOSystemReq().FactoryMetod(DBtype.MongoDB);

        public static void MongoClear()
        {
            daoGameMongo.TruncateGame();
            daoUserMongo.TruncateUser();
            daoSysReqMongo.TruncateSysReq();
            daoLibraryMongo.TruncateLibrary();
        }
        public static void SQLClear()
        {
            daoGameSQL.TruncateGame();
            daoUserSQL.TruncateUser();
        }
        public static void Migrate_SQL_To_MongoBD()
        {
            List<Game> listGames = daoGameSQL.GetAllGame();
            List<SystemReq> listSysReqTemp = daoSysReqSQL.GetAllSystemReq();
            List<User> listUser = daoUserSQL.GetAllUsers();
            List<SystemReq> listSysReq = new List<SystemReq>();
            foreach (var systemReq in listSysReqTemp)
            {
                if (daoSysReqMongo.GetSystemReqById(systemReq.IdSystemReq) == null)
                {
                    listSysReq.Add(systemReq);
                }
            }

            foreach (Game game in listGames)
            {
                
                game.GameGenre = daoGameSQL.GetGameGenres(game.GameId);
                foreach (SystemReq systemReq in listSysReq)
                {
                    if (systemReq.Game.GameId == game.GameId)
                    {
                        systemReq.Game = game;
                        daoSysReqMongo.AddSystemReq(systemReq);
                    }
                }
                if (daoGameMongo.GetGameById(game.GameId) == null)
                {
                    daoGameMongo.AddGame(game);
                }
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
                        if (daoLibraryMongo.GetAllUserLibrary(user.UserId) == null)
                        {
                            daoLibraryMongo.AddLibrary(library);
                        }
                    }
                }

                if (daoUserMongo.GetUserById(user.UserId) == null)
                {
                    daoUserMongo.AddUser(user);
                }
            }
            
        }

        public static void Migrate_MongoDB_To_SQL()
        {
            List<Game> listGames = daoGameMongo.GetAllGame();
            List<SystemReq> listSysReqTemp = daoSysReqMongo.GetAllSystemReq();
            List<User> listUser = daoUserMongo.GetAllUsers();
            List<SystemReq> listSysReq = new List<SystemReq>();
            foreach (var systemReq in listSysReqTemp)
            {
                if (daoSysReqSQL.GetSystemReqById(systemReq.IdSystemReq) == null)
                {
                    listSysReq.Add(systemReq);
                }
            }
            foreach (Game game in listGames)
            {
                List<GameGenre> genres = daoGameMongo.GetGameGenres(game.GameId);
                foreach (var genre in genres)
                {
                    daoGameSQL.AddGenreByName(genre.genreName);
                }

                game.GameGenre = genres;
                if (daoGameSQL.GetGameById(game.GameId) == null)
                {
                    daoGameSQL.AddGame(game);
                }

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
                if (daoUserSQL.GetUserById(user.UserId) == null)
                {
                    daoUserSQL.AddUser(user);
                }
                List<UserGameLibrary> listLibrary = daoLibraryMongo.GetAllUserLibrary(user.UserId);
                if (listLibrary != null)
                {
                    foreach (UserGameLibrary library in listLibrary)
                    {
                        if (daoLibrarySQL.GetAllUserLibrary(user.UserId) == null)
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
}
