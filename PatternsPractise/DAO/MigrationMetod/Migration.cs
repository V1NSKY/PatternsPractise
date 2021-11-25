using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
using PatternsPractise.DAO.DAOLibrary.FactoryDAOLibrary;
using PatternsPractise.DAO.DAOSystemReq.FactorySystemReq;
using PatternsPractise.DAO.FactoryDAOUser;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.MigrationMetod
{
    class Migration
    {
        IDAOGame daoGameSQL = new CreatorDBDAOGame().FactoryMetod(DBtype.MySQL);
        IDAOUser daoUserSQL = new CreatorDBDAOUser().FactoryMetod(DBtype.MySQL);
        IDAOLibrary daoLibrarySQL = new CreatorDBDAOLibrary().FactoryMetod(DBtype.MySQL);
        IDAOSystemReq daoSysReqSQL = new CreatorDBDAOSystemReq().FactoryMetod(DBtype.MySQL);
        IDAOGame daoGameMongo = new CreatorDBDAOGame().FactoryMetod(DBtype.MongoDB);
        IDAOUser daoUserMongo = new CreatorDBDAOUser().FactoryMetod(DBtype.MongoDB);
        IDAOLibrary daoLibraryMongo = new CreatorDBDAOLibrary().FactoryMetod(DBtype.MongoDB);
        IDAOSystemReq daoSysReqMongo = new CreatorDBDAOSystemReq().FactoryMetod(DBtype.MongoDB);

        public void Migrate_SQL_To_MongoBD()
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
    }
}
