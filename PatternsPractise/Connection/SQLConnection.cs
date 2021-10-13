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
        static public String connectionString = "server=localhost;uid=root;pwd=root;database=gamelibrarydb";
        private SQLConnection() { }
        public static MySqlConnection GetConnection()
        {
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
