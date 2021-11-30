using MySql.Data.MySqlClient;
using PatternsPractise.DAO.DAOGame.FactoryDAOGame;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using static PatternsPractise.Entities.Game;
using static PatternsPractise.Entities.SystemReq;

namespace PatternsPractise.DAO.DAOSystemReq
{
    class DAOSystemReq : IDAOSystemReq
    {
        readonly String SQLInsertSystemReq = "INSERT INTO gamelibrarydb.systemreq (idGame, idSystemReqType ,sr_OS,sr_processor,sr_RAM,sr_video,sr_space) VALUE (@idGame, @idSystemReqType,@sr_OS, @sr_processor, @sr_RAM, @sr_video, @sr_space);";
        readonly String SQLInsertSystemReqWithId = "INSERT INTO gamelibrarydb.systemreq (idSystemReq, idGame, idSystemReqType ,sr_OS,sr_processor,sr_RAM,sr_video,sr_space) VALUE (@idSystemReq ,@idGame, @idSystemReqType,@sr_OS, @sr_processor, @sr_RAM, @sr_video, @sr_space);";
        readonly String SQLDeleteSystemReq = "DELETE FROM gamelibrarydb.systemreq WHERE idSystemReq = @idSystemReq;";
        readonly String SQLSelectAllSystemReq = "SELECT * FROM gamelibrarydb.systemreq;";
        readonly String SQLSelectSystemReqByGameId = "SELECT * FROM gamelibrarydb.systemreq WHERE idGame = @idGame;";
        readonly String SQLSelectSystemReqById = "SELECT * FROM gamelibrarydb.systemreq WHERE idSystemReq = @idSystemReq;";
        readonly String SQLUpdateSystemReq = "UPDATE gamelibrarydb.systemreq SET idGame = @idGame, idSystemReqType = @idSystemReqType, sr_OS = @sr_OS, sr_processor = @sr_processor, sr_RAM = @sr_RAM, sr_video = @sr_video, sr_space = @sr_space WHERE idSystemReq = @idSystemReq;";
        public DAOSystemReq() { }
        public void TruncateSysReq()
        {
            throw new NotImplementedException();
        }

        public string AddSystemReq(SystemReq systemReq)
        {
            CreatorDAOGame creatorDAOGame = new CreatorDBDAOGame();
            IDAOGame daoGame = creatorDAOGame.FactoryMetod(DBtype.MySQL);
            String returnString = "";

            Game game = daoGame.GetGameById(systemReq.Game.GameId);
            if (game == null)
            {
                return "Игра не найдена";
            }

            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn
                };
                if (systemReq.IdSystemReq != 0)
                {
                    cmd.CommandText = SQLInsertSystemReqWithId;
                    cmd.Parameters.AddWithValue("@idSystemReq", systemReq.IdSystemReq);
                }
                else
                {
                    cmd.CommandText = SQLInsertSystemReq;
                }
                conn.Open();
                cmd.Parameters.AddWithValue("@idGame", systemReq.Game.GameId);
                cmd.Parameters.AddWithValue("@idSystemReqType", systemReq.IdSystemReqType);
                cmd.Parameters.AddWithValue("@sr_OS", systemReq.Sr_OS);
                cmd.Parameters.AddWithValue("@sr_processor", systemReq.Processor);
                cmd.Parameters.AddWithValue("@sr_RAM", systemReq.Sr_RAM);
                cmd.Parameters.AddWithValue("@sr_video", systemReq.Sr_Video);
                cmd.Parameters.AddWithValue("@sr_space", systemReq.Sr_space);
                returnString += " Добавлено " + cmd.ExecuteNonQuery() + " запись ";
            }
            
            return returnString;
        }

        public string DeleteSystemReq(int idSystemReq)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLDeleteSystemReq
                };
                cmd.Parameters.AddWithValue("@idSystemReq", idSystemReq);
                return " Изменено " + cmd.ExecuteNonQuery() + " запись ";
            }
        }

        public List<SystemReq> GetAllSystemReq()
        {
            List<SystemReq> listSystemReqs = new List<SystemReq>();

            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectAllSystemReq
                };
                conn.Open();

                using (MySqlDataReader selectAllSystemReqReader = cmd.ExecuteReader())
                {
                    if (selectAllSystemReqReader.HasRows)
                    {
                        while (selectAllSystemReqReader.Read())
                        {
                            SystemReq systemReq = new ReqBuilder()
                                .idSystemReq(Convert.ToInt32(selectAllSystemReqReader.GetValue(0)))
                                .idSystemReqType(Convert.ToInt32(selectAllSystemReqReader.GetValue(2)))
                                .game(new GameBuilder().gameId(Convert.ToInt32(selectAllSystemReqReader.GetValue(1))).Build())
                                .sr_OS(selectAllSystemReqReader.GetString(3))
                                .processor(selectAllSystemReqReader.GetString(4))
                                .sr_RAM(Convert.ToUInt32(selectAllSystemReqReader.GetValue(5)))
                                .sr_video(selectAllSystemReqReader.GetString(6))
                                .sr_space(Convert.ToUInt32(selectAllSystemReqReader.GetValue(7)))
                                .Build();
                            listSystemReqs.Add(systemReq);
                        }
                    }
                }
            }
            
            return listSystemReqs;
        }

        public List<SystemReq> GetSystemReqByGameId(int idGame)
        {
            List<SystemReq> listSystemReqs = new List<SystemReq>();

            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectSystemReqByGameId
                };
                cmd.Parameters.AddWithValue("@idGame", idGame);
                conn.Open();

                using (MySqlDataReader selectSystemReqByGameIdReader = cmd.ExecuteReader())
                {
                    if (selectSystemReqByGameIdReader.HasRows)
                    {
                        while (selectSystemReqByGameIdReader.Read())
                        {
                            SystemReq systemReq = new ReqBuilder()
                                .idSystemReq(Convert.ToInt32(selectSystemReqByGameIdReader.GetValue(0)))
                                .idSystemReqType(Convert.ToInt32(selectSystemReqByGameIdReader.GetValue(2)))
                                .game(new GameBuilder().gameId(Convert.ToInt32(selectSystemReqByGameIdReader.GetValue(1))).Build())
                                .sr_OS(selectSystemReqByGameIdReader.GetString(3))
                                .processor(selectSystemReqByGameIdReader.GetString(4))
                                .sr_RAM(Convert.ToUInt32(selectSystemReqByGameIdReader.GetValue(5)))
                                .sr_video(selectSystemReqByGameIdReader.GetString(6))
                                .sr_space(Convert.ToUInt32(selectSystemReqByGameIdReader.GetValue(7)))
                                .Build();
                            listSystemReqs.Add(systemReq);
                        }
                    }
                }
            }
            
            return listSystemReqs;
        }

        public SystemReq GetSystemReqById(int idSystemReq)
        {
            SystemReq systemReq = new ReqBuilder().Build();

            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLSelectSystemReqById
                };
                cmd.Parameters.AddWithValue("@idSystemReq", idSystemReq);
                conn.Open();

                using (MySqlDataReader selectSystemReqByIdReader = cmd.ExecuteReader())
                {
                    if (selectSystemReqByIdReader.HasRows)
                    {
                        while (selectSystemReqByIdReader.Read())
                        {
                            systemReq = new ReqBuilder()
                                .idSystemReq(Convert.ToInt32(selectSystemReqByIdReader.GetValue(0)))
                                .game(new GameBuilder().gameId(Convert.ToInt32(selectSystemReqByIdReader.GetValue(1))).Build())
                                .idSystemReqType(Convert.ToInt32(selectSystemReqByIdReader.GetValue(2)))
                                .sr_OS(selectSystemReqByIdReader.GetString(3))
                                .processor(selectSystemReqByIdReader.GetString(4))
                                .sr_RAM(Convert.ToUInt32(selectSystemReqByIdReader.GetValue(5)))
                                .sr_video(selectSystemReqByIdReader.GetString(6))
                                .sr_space(Convert.ToUInt32(selectSystemReqByIdReader.GetValue(7)))
                                .Build();
                        }
                    }
                }
            }
            
            return systemReq;
        }

        public string UpdateSystemReq(SystemReq systemReq)
        {
            using (MySqlConnection conn = Connection.Connection.GetSQLConnection())
            {
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = conn,
                    CommandText = SQLUpdateSystemReq
                };
                conn.Open();

                cmd.Parameters.AddWithValue("@idSystemReq", systemReq.IdSystemReq);
                cmd.Parameters.AddWithValue("@idSystemReqType", systemReq.IdSystemReqType);
                cmd.Parameters.AddWithValue("@idGame", systemReq.Game.GameId);
                cmd.Parameters.AddWithValue("@sr_OS", systemReq.Sr_OS);
                cmd.Parameters.AddWithValue("@sr_processor", systemReq.Processor);
                cmd.Parameters.AddWithValue("@sr_RAM", systemReq.Sr_RAM);
                cmd.Parameters.AddWithValue("@sr_video", systemReq.Sr_Video);
                cmd.Parameters.AddWithValue("@sr_space", systemReq.Sr_space);
                return " Изменено " + cmd.ExecuteNonQuery() + " запись ";
            }
        }
    }
}
