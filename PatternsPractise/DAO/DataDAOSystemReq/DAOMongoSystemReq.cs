using MongoDB.Bson;
using MongoDB.Driver;
using PatternsPractise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public string UpdateSystemReq(SystemReq systemReq)
        {
            Connection.Connection.GetMongoDataBase().GetCollection<SystemReq>("SystemReq").ReplaceOne(Builders<SystemReq>.Filter.Eq("IdSystemReq", systemReq.IdSystemReq), systemReq);
            return "Updated";
        }
    }
}
