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
        public static MySqlConnection GetConnection(String connString)
        {
            if (connection == null)
            {
                return connection = new MySqlConnection(connString);
            }
            else
            {
                return connection;
            }   
        }     
    }
}
