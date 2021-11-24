using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MongoDB.Bson;
using MongoDB.Driver;

namespace PatternsPractise.Connection
{
    public sealed class Connection
    {
        static private MySqlConnection connection;
        static private MongoClient mongoClient;
        static private IMongoDatabase _mongoDataBase;
        private Connection() { }
        public static MySqlConnection GetSQLConnection()
        {
            if (connection == null)
            {
                return connection = new MySqlConnection("server=localhost;uid=root;pwd=root;database=gamelibrarydb");
            }
            else
            {
                return connection;
            }   
        }
        public static IMongoDatabase GetMongoDataBase()
        {
            if (_mongoDataBase == null)
            {
                return _mongoDataBase = new MongoClient("mongodb://localhost:27017").GetDatabase("gamelibrarydb");
            }
            else
            {
                return _mongoDataBase;
            }
        }
    }
}
