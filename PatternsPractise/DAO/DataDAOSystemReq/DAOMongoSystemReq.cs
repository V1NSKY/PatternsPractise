using MongoDB.Bson;
using MongoDB.Driver;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PatternsPractise.DAO.DataDAOSystemReq
{
    class DAOMongoSystemReq : IDAOSystemReq
    {
        public string AddSystemReq(SystemReq systemReq)
        {
            if(systemReq.IdSystemReq == 0)
            {
                systemReq.IdSystemReq = new Random().Next();
            }            
            Connection.Connection.GetMongoDataBase().GetCollection<SystemReq>("SystemReq").InsertOne(systemReq);
            return "Inserted";
        }

        public List<BsonDocument> Agr_query_1()
        {
            var collection = Connection.Connection.GetMongoDataBase().GetCollection<SystemReq>("SystemReq");
            return collection.Aggregate()
                .Match(new BsonDocument { { "Processor", "Intel Core I5" } })
                .Group(new BsonDocument { { "_id", "$Processor" }, { "gameCount", new BsonDocument("$sum", 1) } })
                .Project(new BsonDocument { { "_id", 0 }, { "ProcessorName", "$_id" }, { "gameCount", 1 } })
                .ToList();
        }

        public List<BsonDocument> Agr_query_2()
        {
            var collection = Connection.Connection.GetMongoDataBase().GetCollection<SystemReq>("SystemReq");
            return collection.Aggregate()
                .Group(new BsonDocument { { "_id", "$Game.GameDeveloper" }, { "gameCount", new BsonDocument("$sum", 1) } })
                .Project(new BsonDocument { { "_id", 0 }, { "developerName", "$_id" }, { "gameCount", 1 } })
                .ToList();
        }

        public List<BsonDocument> Agr_query_3()
        {
            var collection = Connection.Connection.GetMongoDataBase().GetCollection<SystemReq>("SystemReq");
            return collection.Aggregate()
                .Match(Builders<SystemReq>.Filter.Gte(s=>s.Sr_RAM,4) & Builders<SystemReq>.Filter.Lte(s => s.Sr_RAM, 12))
                .Group(new BsonDocument { { "_id", "$Sr_RAM" }, { "gameCount", new BsonDocument("$sum", 1) } })
                .Project(new BsonDocument { { "_id", 0 }, { "RAM", "$_id" }, { "gameCount", 1 } })
                .Sort("{RAM:-1}")
                .ToList();
        }

        public List<BsonDocument> Agr_query_4()
        {
            var collection = Connection.Connection.GetMongoDataBase().GetCollection<SystemReq>("SystemReq");
            return collection.Aggregate()
                .Match(new BsonDocument { { "Sr_Video", "GeForce RTX 2070" }, { "Processor", "Ryzen 7" } })
                .Group(new BsonDocument { { "_id", "$Sr_OS" }, { "gameCount", new BsonDocument("$sum", 1) } })
                .Project(new BsonDocument { { "_id", 0 }, { "OS", "$_id" }, { "gameCount", 1 } })
                .ToList();
        }

        public List<BsonDocument> Agr_query_5()
        {
            var collection = Connection.Connection.GetMongoDataBase().GetCollection<SystemReq>("SystemReq");
            return collection.Aggregate()
                .Match(new BsonDocument {{ "Sr_OS", "Linux" }})
                .Group(new BsonDocument { { "_id", "$Sr_OS" }, { "gameCount", new BsonDocument("$sum", 1) } })
                .Project(new BsonDocument { { "_id", 0 }, { "OS", "$_id" }, { "gameCount", 1 } })
                .ToList();
        }

        public string DeleteSystemReq(int idSystemReq)
        {
            Connection.Connection.GetMongoDataBase().GetCollection<BsonDocument>("SystemReq").DeleteOne(new BsonDocument("IdSystemReq", idSystemReq));
            return "Deleted";
        }

        public List<SystemReq> GetAllSystemReq()
        {
            return Connection.Connection.GetMongoDataBase().GetCollection<SystemReq>("SystemReq").Find<SystemReq>(Builders<SystemReq>.Filter.Empty).ToList<SystemReq>();
        }

        public List<SystemReq> GetSystemReqByGameId(int idGame)
        {
            return Connection.Connection.GetMongoDataBase().GetCollection<SystemReq>("SystemReq").Find<SystemReq>(Builders<SystemReq>.Filter.Eq("Game.GameId", idGame)).ToList<SystemReq>();
        }

        public SystemReq GetSystemReqById(int idSystemReq)
        {
            return Connection.Connection.GetMongoDataBase().GetCollection<SystemReq>("SystemReq").Find<SystemReq>(Builders<SystemReq>.Filter.Eq("IdSystemReq", idSystemReq)).ToList().LastOrDefault();
        }

        public void TruncateSysReq()
        {
            var db = Connection.Connection.GetMongoDataBase();
                db.DropCollection("SystemReq");
                db.CreateCollection("SystemReq");
                db.GetCollection<SystemReq>("SystemReq").Indexes
                    .CreateOne(new CreateIndexModel<SystemReq>(Builders<SystemReq>.IndexKeys.Ascending(systemReq => systemReq.IdSystemReq), new CreateIndexOptions() { Unique = true }));
        }

        public string UpdateSystemReq(SystemReq systemReq)
        {
            Connection.Connection.GetMongoDataBase().GetCollection<SystemReq>("SystemReq").ReplaceOne(Builders<SystemReq>.Filter.Eq("IdSystemReq", systemReq.IdSystemReq), systemReq);
            return "Updated";
        }
    }
}
