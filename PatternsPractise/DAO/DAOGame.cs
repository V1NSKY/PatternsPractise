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
        readonly String  SQLInsertGame = "INSERT INTO gamelibrarydb.game(gameDeveloper,gamePublisher,gameName,gamePrice,gameDateOfRelease,gameDescription) VALUES(@gameDeveloper, @gamePublisher, @gameName, @gamePrice, @gameDateOfRelease, @gameDescription);";
        readonly String SQLSelectGenreByName = "SELECT idGameGenre FROM gamelibrarydb.gamegenre WHERE genreName = @genreName;";
        readonly String SQLInsertSpecificGenre = "INSERT INTO gamelibrarydb.specificgenre VALUES (@idGame,@idGameGenre);";
        readonly String SQLSelectNewIdGame = "SELECT idGame FROM gamelibrarydb.game WHERE idGame=(SELECT max(idGame) FROM gamelibrarydb.game);";
        readonly String SQLSelectAllGames = "SELECT * FROM gamelibrarydb.game";
        readonly String SQLSelectIdGenreByIdGame = "SELECT idGameGenre FROM gamelibrarydb.specificgenre WHERE idGame = @idGame;";
        readonly String SQLSelectGenreById = "SELECT genreName FROM gamelibrarydb.gamegenre WHERE idGameGenre = @idGameGenre;";
        readonly String SQLSelectGameByName = "SELECT * FROM gamelibrarydb.game WHERE gameName = @gameName;";
        readonly String SQLDeleteGameById = "DELETE FROM gamelibrarydb.game WHERE idGame = @idGame;";
        readonly String SQLSelectGameById = "SELECT * FROM gamelibrarydb.game WHERE idGame = @idGame;";
        readonly String SQLUpdateGame = "UPDATE gamelibrarydb.game SET gameDeveloper = @gameDeveloper, gamePublisher = @gamePublisher, gameName = @gameName, gamePrice = @gamePrice, gameDateOfRelease = @gameDateOfRelease, gameDescription = @gameDescription WHERE idGame = @idGame;";
        readonly String SQLConnectionString;
        public DAOGame(String SQLConnectionString) { this.SQLConnectionString = SQLConnectionString; }

        //DAO AddGame

        public String AddGame(Game game)
        {
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            String returnString = "";
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn
            };

            //Check for genre

            conn.Open();
            cmd.CommandText = SQLSelectGenreByName;
            List<Int32> idGenres = new List<int>();
            int countIdGenres = 0;
            foreach(GameGenre genre in game.GetGenres())
            {
                cmd.Parameters.Add("@genreName", MySqlDbType.VarChar).Value = genre.genreName;
                using (MySqlDataReader checkGenreReader = cmd.ExecuteReader())
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
            using(MySqlDataReader selectNewGameReader = cmd.ExecuteReader())
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

        //DAO DeleteGame

        public String DeleteGame(int idGame)
        {
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLDeleteGameById
            };
            cmd.Parameters.AddWithValue("@idGame", idGame);
            conn.Open();
            String returnString = "";
            returnString += "Удалено " + cmd.ExecuteNonQuery() + " записей ";
            cmd.Parameters.Clear();
            conn.Close();
            return returnString;
        }

        //GetGameGenres for specific game

        public List<GameGenre> GetGameGenres(int idGame)
        {
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            List<GameGenre> listGameGenres = new List<GameGenre>();
            List<int> listIdGenres = new List<int>();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn
            };
            conn.Open();
            cmd.CommandText = SQLSelectIdGenreByIdGame;
            cmd.Parameters.AddWithValue("@idGame", idGame);
            using (MySqlDataReader selectSpecificGameGenres = cmd.ExecuteReader())
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
                using (MySqlDataReader selectGenresByIdReader = cmd.ExecuteReader())
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

        //DAO GetAllGame

        public List<Game> GetAllGame()
        {
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            List<Game> listGames = new List<Game>();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLSelectAllGames
            };
            conn.Open();
            using (MySqlDataReader selectAllGamesReader = cmd.ExecuteReader())
            {
                if (selectAllGamesReader.HasRows)
                {
                    while (selectAllGamesReader.Read())
                    {
                        Game game = new GameBuilder()
                            .gameId(Convert.ToInt32(selectAllGamesReader.GetValue(0)))
                            .gameDeveloper(selectAllGamesReader.GetString(1))
                            .gamePublisher(selectAllGamesReader.GetString(2))
                            .gameName(selectAllGamesReader.GetString(3))
                            .gamePrice(Convert.ToDouble(selectAllGamesReader.GetString(4)))
                            .gameDateOfRelease(Convert.ToDateTime(selectAllGamesReader.GetString(5)).ToString("yyyy.MM.dd"))
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

        //DAO SearchGameByName

        public List<Game> SearchGameByName(string gameName)
        {
            List<Game> listGames = new List<Game>();
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLSelectGameByName
            };
            cmd.Parameters.AddWithValue("@gameName", gameName);
            conn.Open();
            using (MySqlDataReader selectGameByNameReader = cmd.ExecuteReader())
            {
                if (selectGameByNameReader.HasRows)
                {
                    while (selectGameByNameReader.Read())
                    {
                        Game game = new GameBuilder()
                            .gameId(Convert.ToInt32(selectGameByNameReader.GetValue(0)))
                            .gameDeveloper(selectGameByNameReader.GetString(1))
                            .gamePublisher(selectGameByNameReader.GetString(2))
                            .gameName(selectGameByNameReader.GetString(3))
                            .gamePrice(Convert.ToDouble(selectGameByNameReader.GetString(4)))
                            .gameDateOfRelease(Convert.ToDateTime(selectGameByNameReader.GetString(5)).ToString("yyyy.MM.dd"))
                            .gameDescription(selectGameByNameReader.GetString(6))
                            .Build();
                        listGames.Add(game);
                    }
                }
            }
            cmd.Parameters.Clear();
            conn.Close();
            return listGames;
        }

        //DAO UpdateGame

        public String UpdateGame(Game updatedGame)
        {
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn
            };
            String returnString = "";
            cmd.Parameters.Clear();
            cmd.CommandText = SQLUpdateGame;
            cmd.Parameters.AddWithValue("@idGame", updatedGame.GameId);
            cmd.Parameters.AddWithValue("@gameDeveloper", updatedGame.GameDeveloper);
            cmd.Parameters.AddWithValue("@gamePublisher", updatedGame.GamePublisher);
            cmd.Parameters.AddWithValue("@gameName", updatedGame.GameName);
            cmd.Parameters.AddWithValue("@gamePrice", updatedGame.GamePrice);
            cmd.Parameters.AddWithValue("@gameDateOfRelease", updatedGame.DateOfRelease);
            cmd.Parameters.AddWithValue("@gameDescription", updatedGame.GameDescription);
            returnString +=" Изменено " + cmd.ExecuteNonQuery() + " запись ";
            cmd.Parameters.Clear();
            conn.Close();
            return returnString;

        }

        //DAO GetGameById

        public Game GetGameById(int idGame)
        {
            Game game = new GameBuilder().Build();
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLSelectGameById
            };
            cmd.Parameters.AddWithValue("@idGame", idGame);
            conn.Open();
            using (MySqlDataReader selectGameByIdReader = cmd.ExecuteReader())
            {
                if (selectGameByIdReader.HasRows)
                {
                    while (selectGameByIdReader.Read())
                    {
                        game = new GameBuilder()
                            .gameId(Convert.ToInt32(selectGameByIdReader.GetValue(0)))
                            .gameDeveloper(selectGameByIdReader.GetString(1))
                            .gamePublisher(selectGameByIdReader.GetString(2))
                            .gameName(selectGameByIdReader.GetString(3))
                            .gamePrice(Convert.ToDouble(selectGameByIdReader.GetString(4)))
                            .gameDateOfRelease(Convert.ToDateTime(selectGameByIdReader.GetString(5)).ToString("yyyy.MM.dd"))
                            .gameDescription(selectGameByIdReader.GetString(6))
                            .Build();
                    }
                }
            }
            cmd.Parameters.Clear();
            conn.Close();
            return game;
        }
    }
}
