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
    public class Connection
    {
        static private MySqlConnection connection;
        static private MongoClient mongoClient;
        static private IMongoDatabase _mongoDataBase;
        static public String connectionString = "server=localhost;uid=root;pwd=root;database=gamelibrarydb";
        static public String mongoConnectionString = "mongodb://localhost:27017";
        private Connection() { }
        public static MySqlConnection GetSQLConnection()
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
        public static IMongoDatabase GetMongoDataBase()
        {
            if (_mongoDataBase == null)
            {
                mongoClient = new MongoClient(mongoConnectionString);
                return _mongoDataBase = mongoClient.GetDatabase("gamelibrarydb");
            }
            else
            {
                return _mongoDataBase;
            }
        }
    }
}
