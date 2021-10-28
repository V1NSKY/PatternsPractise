﻿using MySql.Data.MySqlClient;
using PatternsPractise.Connection;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PatternsPractise.Entities.Game;
using static PatternsPractise.Entities.User;
using static PatternsPractise.Entities.UserGameLibrary;

namespace PatternsPractise.DAO.DAOLibrary
{
    class DAOLibrary : IDAOLibrary
    {
        readonly String SQLInsertUserGameLibrary = "INSERT INTO gamelibrarydb.usergamelibrary (idGame,idUser,dateAdded,hoursPlayed,dateLastPlayed) VALUES (@idGame,@idUser,curdate(),@hoursPlayed,curdate());";
        readonly String SQLDeleteUserLibrary = "DELETE FROM gamelibrarydb.usergamelibrary WHERE idUser = @idUser;";
        readonly String SQLDeleteUserLibraryGame = "DELETE FROM gamelibrarydb.usergamelibrary WHERE idGame = @idGame;";
        readonly String SQLSelectAllUserLibraryGame = "SELECT * FROM gamelibrarydb.usergamelibrary WHERE idUser = @idUser";
        public string AddLibrary(UserGameLibrary userGameLibrary)
        {
            List<UserGameLibrary> library = GetAllUserLibrary(userGameLibrary.User.UserId);

            if(library != null)
            {
                foreach (UserGameLibrary gameLibrary in library)
                {
                    if (userGameLibrary.Game.GameId == gameLibrary.Game.GameId)
                    {
                        return "Игра уже есть в библиотеке";
                    }
                }
            }
           

            using(MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLInsertUserGameLibrary
                };

                conn.Open();
                cmd.Parameters.AddWithValue("@idGame", userGameLibrary.Game.GameId);
                cmd.Parameters.AddWithValue("@idUser", userGameLibrary.User.UserId);
                cmd.Parameters.AddWithValue("@hoursPlayed", userGameLibrary.HoursPlayed);
                cmd.ExecuteNonQuery();
                return "Игра добавлена в библиотеку";
            }
        }

        public string DeleteLibrary(int idUser)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLDeleteUserLibrary
                };

                conn.Open();
                cmd.Parameters.AddWithValue("@idUser", idUser);
                return cmd.ExecuteNonQuery().ToString();
            }
        }

        public int DeleteLibraryGame(int idGame)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLDeleteUserLibraryGame
                };

                conn.Open();
                cmd.Parameters.AddWithValue("@idGame", idGame);
                return cmd.ExecuteNonQuery();
            }
        }

        public List<UserGameLibrary> GetAllUserLibrary(int idUser)
        {
            List<UserGameLibrary> listLibrary = new List<UserGameLibrary>();

            using(MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectAllUserLibraryGame
                };
                cmd.Parameters.AddWithValue("@idUser", idUser);
                conn.Open();

                using(MySqlDataReader selectAllReader = cmd.ExecuteReader())
                {
                    if (selectAllReader.HasRows)
                    {
                        while (selectAllReader.Read())
                        {
                            UserGameLibrary userGameLibrary = new LibraryBuilder()
                                .user(new UserBuilder(1).userId(idUser).Build())
                                .game(new GameBuilder().gameId(Convert.ToInt32(selectAllReader.GetValue(0))).Build())
                                .dateAdded(Convert.ToDateTime(selectAllReader.GetString(2)).ToString("yyyy.MM.dd"))
                                .hoursPlayed(Convert.ToInt32(selectAllReader.GetValue(3)))
                                .dateLastPlayed(Convert.ToDateTime(selectAllReader.GetString(4)).ToString("yyyy.MM.dd"))
                                .Build();
                            listLibrary.Add(userGameLibrary);
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return listLibrary;
        }
    }
}
