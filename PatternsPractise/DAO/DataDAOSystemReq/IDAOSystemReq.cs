using System;
using System.Collections.Generic;
using PatternsPractise.Entities;

namespace PatternsPractise.DAO
{
    public interface IDAOSystemReq
    {
        public String AddSystemReq(SystemReq systemReq);
        public String DeleteSystemReq(int idSystemReq);
        public String UpdateSystemReq(SystemReq systemReq);
        public SystemReq GetSystemReqById(int idSystemReq);
        public List<SystemReq> GetAllSystemReq();
        public List<SystemReq> GetSystemReqByGameId(int idGame);
    }
}
