using MongoDB.Bson;
using MongoDB.Driver;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.DAO.DataDAOSystemReq
{
    class DAOMongoSystemReq : IDAOSystemReq
    {
        public string AddSystemReq(SystemReq systemReq)
        {
            Random random = new Random();
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            var collection = database.GetCollection<SystemReq>("SystemReq");
            systemReq.IdSystemReq = random.Next();
            collection.InsertOne(systemReq);
            return "Inserted";
        }

        public string DeleteSystemReq(int idSystemReq)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            var collection = database.GetCollection<BsonDocument>("SystemReq");
            var filter = new BsonDocument("IdSystemReq", idSystemReq);
            collection.DeleteOne(filter);
            return "Deleted";
        }

        public List<SystemReq> GetAllSystemReq()
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<SystemReq> collection = database.GetCollection<SystemReq>("SystemReq");
            FilterDefinition<SystemReq> filter = Builders<SystemReq>.Filter.Empty;
            return collection.Find<SystemReq>(filter).ToList<SystemReq>();
        }

        public List<SystemReq> GetSystemReqByGameId(int idGame)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<SystemReq> collection = database.GetCollection<SystemReq>("SystemReq");
            FilterDefinition<SystemReq> filter = Builders<SystemReq>.Filter.Eq("Game.GameId", idGame);
            return collection.Find<SystemReq>(filter).ToList<SystemReq>();
        }

        public SystemReq GetSystemReqById(int idSystemReq)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<SystemReq> collection = database.GetCollection<SystemReq>("SystemReq");
            FilterDefinition<SystemReq> filter = Builders<SystemReq>.Filter.Eq("IdSystemReq", idSystemReq);
            return collection.Find<SystemReq>(filter).ToList().LastOrDefault();
        }

        public string UpdateSystemReq(SystemReq systemReq)
        {
            IMongoDatabase database = Connection.Connection.GetMongoDataBase();
            IMongoCollection<SystemReq> collection = database.GetCollection<SystemReq>("SystemReq");
            FilterDefinition<SystemReq> filter = Builders<SystemReq>.Filter.Eq("IdSystemReq", systemReq.IdSystemReq);
            collection.ReplaceOne(filter, systemReq);
            return "Updated";
        }
    }
}
