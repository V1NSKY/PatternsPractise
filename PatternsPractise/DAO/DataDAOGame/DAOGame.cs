﻿using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using static PatternsPractise.Entities.Game;
using MySql.Data.MySqlClient;
using PatternsPractise.DAO.ObserverDAO;
using System.Windows.Forms;
using PatternsPractise.DAO.DAOGame.FactoryDAOGame;

namespace PatternsPractise.DAO.DAOGame
{
    class DAOGame : IDAOGame
    {
        readonly String SQLInsertGame = "INSERT INTO gamelibrarydb.game(gameDeveloper,gamePublisher,gameName,gamePrice,gameDateOfRelease,gameDescription) VALUES(@gameDeveloper, @gamePublisher, @gameName, @gamePrice, @gameDateOfRelease, @gameDescription);";

        private readonly String SQLInsertGameWithId =
            "INSERT INTO gamelibrarydb.game(idGame,gameDeveloper,gamePublisher,gameName,gamePrice,gameDateOfRelease,gameDescription) VALUES(@idGame,@gameDeveloper, @gamePublisher, @gameName, @gamePrice, @gameDateOfRelease, @gameDescription);";
        readonly String SQLInsertGameGenreByName = "INSERT INTO gamelibrarydb.gamegenre(genreName) VALUES(@genreName);";
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
        readonly String SQLGetGenreByName = "SELECT * FROM gamelibrarydb.gamegenre WHERE genreName = @genreName;";
        private readonly String SQLTruncateTable = "DELETE FROM gamelibrarydb.game; DELETE FROM gamelibrarydb.gamegenre;";
        public DAOGame() { }

        private List<IObserverDAOGame> observers = new List<IObserverDAOGame>();

        //DAO AddGame

        public String AddGame(Game game)
        {
            MySqlConnection conn = Connection.Connection.GetSQLConnection();
            String returnString = "";
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLSelectGenreByName
            };

            //Check for genre

            List<int> idGenres = new List<int>();
            int countIdGenres = 0;
            foreach(GameGenre genre in game.GetGenres())
            {
                cmd.Parameters.Add("@genreName", MySqlDbType.VarChar).Value = genre.genreName;
                using (conn)
                {
                    conn.Open();
                    using (MySqlDataReader checkGenreReader = cmd.ExecuteReader())
                    {
                        if (!checkGenreReader.HasRows)
                        {
                            return "Жанр " + genre.genreName + " не найден";
                        }
                        else
                        {
                            while (checkGenreReader.Read())
                            {
                                idGenres.Add(Convert.ToInt32(checkGenreReader.GetValue(0)));
                            }
                        }
                    }
                }
                
                cmd.Parameters.Clear();
            }

            cmd.Parameters.Clear();

            //Add new game

            using (conn)
            {
                conn.Open();
                if (game.GameId != 0)
                {
                    cmd.CommandText = SQLInsertGameWithId;
                    cmd.Parameters.Add("@idGame", MySqlDbType.VarChar).Value = game.GameId;

                }
                else
                {
                    cmd.CommandText = SQLInsertGame;
                }
                cmd.Parameters.Add("@gameDeveloper", MySqlDbType.VarChar).Value = game.GameDeveloper;
                cmd.Parameters.Add("@gamePublisher", MySqlDbType.VarChar).Value = game.GamePublisher;
                cmd.Parameters.Add("@gameName", MySqlDbType.VarChar).Value = game.GameName;
                cmd.Parameters.Add("@gamePrice", MySqlDbType.Float).Value = game.GamePrice;
                cmd.Parameters.Add("@gameDateOfRelease", MySqlDbType.Date).Value = game.DateOfRelease;
                cmd.Parameters.Add("@gameDescription", MySqlDbType.Text).Value = game.GameDescription;
                returnString += "Добавлено " + cmd.ExecuteNonQuery() + " игр; ";
            }

            cmd.Parameters.Clear();

            //Select new game id

            int idGame = 0;
            cmd.CommandText = SQLSelectNewIdGame;

            using (conn)
            {
                conn.Open();
                using (MySqlDataReader selectNewGameReader = cmd.ExecuteReader())
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
            }
            
            cmd.Parameters.Clear();

            //add new specific genres

            int countRecords = 0;
            using (conn)
            {
                conn.Open();
                foreach (int idGenre in idGenres)
                {
                    cmd.CommandText = SQLInsertSpecificGenre;
                    cmd.Parameters.Add("@idGame", MySqlDbType.Int32).Value = idGame;
                    cmd.Parameters.Add("@idGameGenre", MySqlDbType.Int32).Value = idGenre;
                    cmd.ExecuteNonQuery();
                    ++countRecords;
                    cmd.Parameters.Clear();
                }
            }
            
            cmd.Parameters.Clear();
            Notify();
            return returnString + "Добавлено " + countRecords + " записей в жанры игры; ";
        }

        //DAO DeleteGame

        public String DeleteGame(int idGame)
        {
            String returnString = "";

            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLDeleteGameById
                };
                cmd.Parameters.AddWithValue("@idGame", idGame);
                returnString += "Удалено " + cmd.ExecuteNonQuery() + " записей ";
                cmd.Parameters.Clear();
            }
            Notify();
            return returnString;
        }

        //GetGameGenres for specific game

        public List<GameGenre> GetGameGenres(int idGame)
        {
            MySqlConnection conn = Connection.Connection.GetSQLConnection();
            List<GameGenre> listGameGenres = new List<GameGenre>();
            List<int> listIdGenres = new List<int>();
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLSelectIdGenreByIdGame
            };

            cmd.Parameters.AddWithValue("@idGame", idGame);

            using (conn)
            {
                conn.Open();
                using (MySqlDataReader selectSpecificGameGenres = cmd.ExecuteReader())
                {
                    if (selectSpecificGameGenres.HasRows)
                    {
                        while (selectSpecificGameGenres.Read())
                        {
                            listIdGenres.Add(Convert.ToInt32(selectSpecificGameGenres.GetValue(0)));
                        }
                    }
                }
            }
            
            cmd.Parameters.Clear();
            cmd.CommandText = SQLSelectGenreById;

            foreach(int idGenre in listIdGenres)
            {
                cmd.Parameters.AddWithValue("@idGameGenre", idGenre);
                using (conn)
                {
                    conn.Open();
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
                }
                
                cmd.Parameters.Clear();
            }

            return listGameGenres;  
        }

        //DAO GetAllGame

        public List<Game> GetAllGame()
        {
            List<Game> listGames = new List<Game>();

            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectAllGames
                };
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
                }
            }
            
            return listGames;
        }

        //DAO SearchGameByName

        public List<Game> SearchGameByName(string gameName)
        {
            List<Game> listGames = new List<Game>();

            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
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
            }

            return listGames;
        }

        //DAO UpdateGame

        public String UpdateGame(Game updatedGame)
        {
            String returnString = "";

            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLUpdateGame
                };
                cmd.Parameters.AddWithValue("@idGame", updatedGame.GameId);
                cmd.Parameters.AddWithValue("@gameDeveloper", updatedGame.GameDeveloper);
                cmd.Parameters.AddWithValue("@gamePublisher", updatedGame.GamePublisher);
                cmd.Parameters.AddWithValue("@gameName", updatedGame.GameName);
                cmd.Parameters.AddWithValue("@gamePrice", updatedGame.GamePrice);
                cmd.Parameters.AddWithValue("@gameDateOfRelease", updatedGame.DateOfRelease);
                cmd.Parameters.AddWithValue("@gameDescription", updatedGame.GameDescription);
                returnString += " Изменено " + cmd.ExecuteNonQuery() + " запись ";
            }
            Notify();
            return returnString;
        }

        //DAO GetGameById

        public Game GetGameById(int idGame)
        {
            Game game = new GameBuilder().Build();
            
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectGameById
                };
                cmd.Parameters.AddWithValue("@idGame", idGame);
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
                    else
                    {
                        return null;
                    }
                }
            }
            return game;
        }

        public GameGenre GetGameGenreByName(string genreName)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLGetGenreByName
                };
                cmd.Parameters.AddWithValue("@genreName", genreName);
                using (MySqlDataReader selectGenreByNameReader = cmd.ExecuteReader())
                {
                    if (selectGenreByNameReader.HasRows)
                    {
                        selectGenreByNameReader.Read();
                        return new GameGenre(selectGenreByNameReader.GetString(1));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public string AddGenreByName(string genreName)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLInsertGameGenreByName
                };
                if (new CreatorDBDAOGame().FactoryMetod(DBtype.MySQL).GetGameGenreByName(genreName) == null)
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@genreName", genreName);
                    return cmd.ExecuteNonQuery().ToString();
                }
                else
                {
                    return "";
                }
            }
        }

        public Game GetGameByName(string gameName)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                Game game = new GameBuilder().Build();
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
                            game = new GameBuilder()
                                .gameId(Convert.ToInt32(selectGameByNameReader.GetValue(0)))
                                .gameDeveloper(selectGameByNameReader.GetString(1))
                                .gamePublisher(selectGameByNameReader.GetString(2))
                                .gameName(selectGameByNameReader.GetString(3))
                                .gamePrice(Convert.ToDouble(selectGameByNameReader.GetString(4)))
                                .gameDateOfRelease(Convert.ToDateTime(selectGameByNameReader.GetString(5)).ToString("yyyy.MM.dd"))
                                .gameDescription(selectGameByNameReader.GetString(6))
                                .Build();  
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                return game;
            }
        }

        public void AddObserver(IObserverDAOGame observer)
        {
            observers.Add(observer);
        }

        public void DeleteObserver(IObserverDAOGame observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(IObserverDAOGame observer in observers)
            {
                observer.Update();
            }
        }

        public void TruncateGame()
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand() { Connection = conn, CommandText = SQLTruncateTable })
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
        }
    }
}
