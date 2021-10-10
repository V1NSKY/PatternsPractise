using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternsPractise.Connection;
using static PatternsPractise.Entities.Game;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace PatternsPractise.DAO
{
    class DAOGame : IDAOGame
    {
        MySqlConnection conn;
        String SQLInsertGame = "INSERT INTO gamelibrarydb.game(gameDeveloper,gamePublisher,gameName,gamePrice,gameDateOfRelease,gameDescription)" +
            "VALUES (@gameDeveloper,@gamePublisher,@gameName,@gamePrice, @gameDateOfRelease,@gameDescription);";
        String SQLSelectGenreByName = "SELECT idGameGenre FROM gamelibrarydb.gamegenre WHERE genreName = @genreName;";
        String SQLInsertSpecificGenre = "INSERT INTO gamelibrarydb.specificgenre VALUES (@idGame,@idGameGenre);";
        String SQLSelectNewIdGame = "SELECT idGame FROM gamelibrarydb.game WHERE idGame=(SELECT max(idGame) FROM gamelibrarydb.game);";
        String SQLSelectAllGames = "SELECT * FROM gamelibrarydb.game";
        String SQLSelectIdGenreByIdGame = "SELECT idGameGenre FROM gamelibrarydb.specificgenre WHERE idGame = @idGame;";
        String SQLSelectGenreById = "SELECT genreName FROM gamelibrarydb.gamegenre WHERE idGameGenre = @idGameGenre;";
        public DAOGame(MySqlConnection conn) => this.conn = conn;
        public String addGame(Game game)
        {
            String returnString = "";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            //Check for genre

            conn.Open();
            cmd.CommandText = SQLSelectGenreByName;
            List<Int32> idGenres = new List<int>();
            int countIdGenres = 0;
            foreach(GameGenre genre in game.GetGenres())
            {
                cmd.Parameters.Add("@genreName", MySqlDbType.VarChar).Value = genre.genreName;
                using (DbDataReader checkGenreReader = cmd.ExecuteReader())
                {
                    if (!checkGenreReader.HasRows)
                    {
                        return "Жанр"+ genre.genreName +"не найден";
                        conn.Close();
                    }
                    else
                    {
                        idGenres.Add(++countIdGenres);
                    }
                    checkGenreReader.Close();
                }
                cmd.Parameters.Clear();
            }
            cmd.Parameters.Clear();
            conn.Close();

            //Add new game

            conn.Open();
            cmd.CommandText = SQLInsertGame;
            cmd.Parameters.Add("@gameDeveloper", MySqlDbType.VarChar).Value = game.GameDeveloper;
            cmd.Parameters.Add("@gamePublisher", MySqlDbType.VarChar).Value = game.GamePublisher;
            cmd.Parameters.Add("@gameName", MySqlDbType.VarChar).Value = game.GameName;
            cmd.Parameters.Add("@gamePrice", MySqlDbType.Float).Value = game.GamePrice;
            cmd.Parameters.Add("@gameDateOfRelease", MySqlDbType.Date).Value = game.DateOfRelease;
            cmd.Parameters.Add("@gameDescription", MySqlDbType.Text).Value = game.GameDescription;
            returnString += "Добавлено " +cmd.ExecuteNonQuery() + " игр; ";
            conn.Close();
            cmd.Parameters.Clear();

            //Select new game id

            int idGame = 0;
            conn.Open();
            cmd.CommandText = SQLSelectNewIdGame;
            using(DbDataReader selectNewGameReader = cmd.ExecuteReader())
            {
                if (selectNewGameReader.HasRows)
                {
                    while (selectNewGameReader.Read())
                    {
                        idGame = Convert.ToInt32(selectNewGameReader.GetValue(0));
                    }     
                }
                selectNewGameReader.Close();
            }
            cmd.Parameters.Clear();
            conn.Close();

            //add new specific genres
            int countRecords = 0;
            conn.Open();
            foreach(int idGenre in idGenres)
            {
                cmd.CommandText = SQLInsertSpecificGenre;
                cmd.Parameters.Add("@idGame", MySqlDbType.Int32).Value = idGame;
                cmd.Parameters.Add("@idGameGenre", MySqlDbType.Int32).Value = idGenre;
                cmd.ExecuteNonQuery();
                ++countRecords;
                cmd.Parameters.Clear();
            }
            cmd.Parameters.Clear();
            conn.Close();
            return returnString + "Добавлено " + countRecords + " записей в жанры игры; ";
        }
        public void deleteGame(int idGame)
        {
            throw new NotImplementedException();    
        }
        public List<GameGenre> getGameGenres(int idGame)
        {
            List<GameGenre> listGameGenres = new List<GameGenre>();
            List<int> listIdGenres = new List<int>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = SQLSelectIdGenreByIdGame;
            cmd.Parameters.AddWithValue("@idGame", idGame);
            using (DbDataReader selectSpecificGameGenres = cmd.ExecuteReader())
            {
                if (selectSpecificGameGenres.HasRows)
                {
                    while (selectSpecificGameGenres.Read())
                    {
                        listIdGenres.Add(Convert.ToInt32(selectSpecificGameGenres.GetValue(0)));
                    }
                }
                selectSpecificGameGenres.Close();
            }

            cmd.Parameters.Clear();
            cmd.CommandText = SQLSelectGenreById;
            foreach(int idGenre in listIdGenres)
            {
                cmd.Parameters.AddWithValue("@idGameGenre", idGenre);
                using (DbDataReader selectGenresByIdReader = cmd.ExecuteReader())
                {
                    if (selectGenresByIdReader.HasRows)
                    {
                        while (selectGenresByIdReader.Read())
                        {
                            GameGenre gameGenre = new GameGenre(selectGenresByIdReader.GetString(0));
                            listGameGenres.Add(gameGenre);
                        }
                    }
                }
                cmd.Parameters.Clear();
            }
            conn.Close();
            return listGameGenres;  
        }
        public List<Game> GetAllGame()
        {
            List<Game> listGames = new List<Game>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = SQLSelectAllGames;
            conn.Open();
            using (DbDataReader selectAllGamesReader = cmd.ExecuteReader())
            {
                if (selectAllGamesReader.HasRows)
                {
                    while (selectAllGamesReader.Read())
                    {
                        Game game = new GameBuilder()
                            //.listGenre(getGameGenres(Convert.ToInt32(selectAllGamesReader.GetValue(0))))
                            .gameId(Convert.ToInt32(selectAllGamesReader.GetValue(0)))
                            .gameDeveloper(selectAllGamesReader.GetString(1))
                            .gamePublisher(selectAllGamesReader.GetString(2))
                            .gameName(selectAllGamesReader.GetString(3))
                            .gamePrice(Convert.ToDouble(selectAllGamesReader.GetString(4)))
                            .gameDateOfRelease(selectAllGamesReader.GetString(5))
                            .gameDescription(selectAllGamesReader.GetString(6))
                            .Build();
                        listGames.Add(game);
                    }
                }
                selectAllGamesReader.Close();
            }
            conn.Close();
            return listGames;
        }

        public void searchGameByName(string gameName)
        {
            throw new NotImplementedException();
        }

        public void updateGame(int idGame)
        {
            throw new NotImplementedException();
        }
    }
}
