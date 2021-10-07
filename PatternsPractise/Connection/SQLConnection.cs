using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PatternsPractise.Connection
{
    public class SQLConnection
    {
        static private MySqlConnection connection;
        private SQLConnection() { }
        public static MySqlConnection GetConnection(String server,String database,uint port,String username,String password)
        {
            String connectionString = "Server=" + server + ";Database=" + database + ";port="
                + port + ";User id=" + username + ";Password=" + password;
            if (connection == null)
            {
                return connection = new MySqlConnection(connectionString);
            }
            else
            {
                return connection;
            }   
        }     
    }
}
