using MySql.Data.MySqlClient;
using PatternsPractise.Connection;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PatternsPractise.Entities.Game;
using static PatternsPractise.Entities.SystemReq;

namespace PatternsPractise.DAO
{
    class DAOSystemReq : IDAOSystemReq
    {
        readonly String SQLInsertSystemReq = "INSERT INTO gamelibrarydb.systemreq (idGame,sr_OS,sr_processor,sr_RAM,sr_video,sr_space) VALUE (@idGame, @sr_OS, @sr_processor, @sr_RAM, @sr_video, @sr_space);";
        readonly String SQLDeleteSystemReq = "DELETE FROM gamelibrarydb.systemreq WHERE idSystemReq = @idSystemReq;";
        readonly String SQLSelectAllSystemReq = "SELECT * FROM gamelibrarydb.systemreq;";
        readonly String SQLSelectSystemReqByGameId = "SELECT * FROM gamelibrarydb.systemreq WHERE idGame = @idGame;";
        readonly String SQLSelectSystemReqById = "SELECT * FROM gamelibrarydb.systemreq WHERE idSystemReq = @idSystemReq;";
        readonly String SQLUpdateSystemReq = "UPDATE gamelibrarydb.systemreq SET idGame = @idGame, sr_OS = @sr_OS, sr_processor = @sr_processor, sr_RAM = @sr_RAM, sr_video = @sr_video, sr_space = @sr_space WHERE idSystemReq = @idSystemReq;";
        readonly String SQLConnectionString;
        public DAOSystemReq(String SQLConnectionString) { this.SQLConnectionString = SQLConnectionString; }
        public string AddSystemReq(SystemReq systemReq)
        {
            DAOGame daoGame = new DAOGame(SQLConnectionString);
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            String returnString = "";

            Game game = daoGame.GetGameById(systemReq.Game.GameId);
            if (game == null)
            {
                return "Игра не найдена";
            }

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLInsertSystemReq
            };
            conn.Open();

            cmd.Parameters.AddWithValue("@idGame", systemReq.Game.GameId);
            cmd.Parameters.AddWithValue("@sr_OS", systemReq.Sr_OS);
            cmd.Parameters.AddWithValue("@sr_processor", systemReq.Processor);
            cmd.Parameters.AddWithValue("@sr_RAM", systemReq.Sr_RAM);
            cmd.Parameters.AddWithValue("@sr_video", systemReq.Sr_Video);
            cmd.Parameters.AddWithValue("@sr_space", systemReq.Sr_space);
            returnString += " Добавлено " + cmd.ExecuteNonQuery() + " запись ";

            cmd.Parameters.Clear();
            conn.Close();
            return returnString;
        }

        public string DeleteSystemReq(int idSystemReq)
        {
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            String returnString = "";

            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLDeleteSystemReq
            };
            conn.Open();

            cmd.Parameters.AddWithValue("@idSystemReq", idSystemReq);
            returnString += " Изменено " + cmd.ExecuteNonQuery() + " запись ";

            cmd.Parameters.Clear();
            conn.Close();
            return returnString;
        }

        public List<SystemReq> GetAllSystemReq()
        {
            List<SystemReq> listSystemReqs = new List<SystemReq>();
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
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
                            .game(new GameBuilder().gameId(Convert.ToInt32(selectAllSystemReqReader.GetValue(1))).Build())
                            .sr_OS(selectAllSystemReqReader.GetString(2))
                            .processor(selectAllSystemReqReader.GetString(3))
                            .sr_RAM(Convert.ToUInt32(selectAllSystemReqReader.GetValue(4)))
                            .sr_video(selectAllSystemReqReader.GetString(5))
                            .sr_space(Convert.ToUInt32(selectAllSystemReqReader.GetValue(6)))
                            .Build();
                        listSystemReqs.Add(systemReq);
                    }
                }
            }

            cmd.Parameters.Clear();
            conn.Close();
            return listSystemReqs;
        }

        public List<SystemReq> GetSystemReqByGameId(int idGame)
        {
            List<SystemReq> listSystemReqs = new List<SystemReq>();
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
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
                            .game(new GameBuilder().gameId(Convert.ToInt32(selectSystemReqByGameIdReader.GetValue(1))).Build())
                            .sr_OS(selectSystemReqByGameIdReader.GetString(2))
                            .processor(selectSystemReqByGameIdReader.GetString(3))
                            .sr_RAM(Convert.ToUInt32(selectSystemReqByGameIdReader.GetValue(4)))
                            .sr_video(selectSystemReqByGameIdReader.GetString(5))
                            .sr_space(Convert.ToUInt32(selectSystemReqByGameIdReader.GetValue(6)))
                            .Build();
                        listSystemReqs.Add(systemReq);
                    }
                }
            }

            cmd.Parameters.Clear();
            conn.Close();
            return listSystemReqs;
        }

        public SystemReq GetSystemReqById(int idSystemReq)
        {
            SystemReq systemReq = new ReqBuilder().Build();
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
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
                            .sr_OS(selectSystemReqByIdReader.GetString(2))
                            .processor(selectSystemReqByIdReader.GetString(3))
                            .sr_RAM(Convert.ToUInt32(selectSystemReqByIdReader.GetValue(4)))
                            .sr_video(selectSystemReqByIdReader.GetString(5))
                            .sr_space(Convert.ToUInt32(selectSystemReqByIdReader.GetValue(6)))
                            .Build();
                    }
                }
            }

            cmd.Parameters.Clear();
            conn.Close();
            return systemReq;
        }

        public string UpdateSystemReq(SystemReq systemReq)
        {
            MySqlConnection conn = SQLConnection.GetConnection(SQLConnectionString);
            String returnString = "";
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = conn,
                CommandText = SQLUpdateSystemReq
            };
            conn.Open();

            cmd.Parameters.AddWithValue("@idSystemReq", systemReq.IdSystemReq);
            cmd.Parameters.AddWithValue("@idGame", systemReq.Game.GameId);
            cmd.Parameters.AddWithValue("@sr_OS", systemReq.Sr_OS);
            cmd.Parameters.AddWithValue("@sr_processor", systemReq.Processor);
            cmd.Parameters.AddWithValue("@sr_RAM", systemReq.Sr_RAM);
            cmd.Parameters.AddWithValue("@sr_video", systemReq.Sr_Video);
            cmd.Parameters.AddWithValue("@sr_space", systemReq.Sr_space);
            returnString += " Изменено " + cmd.ExecuteNonQuery() + " запись ";

            cmd.Parameters.Clear();
            conn.Close();
            return returnString;
        }
    }
}
