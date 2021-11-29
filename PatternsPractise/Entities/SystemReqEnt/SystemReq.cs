using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PatternsPractise.Entities
{
    [BsonIgnoreExtraElements]
    public class SystemReq
    {
        private Game game;
        private int idSystemReq;
        private int idSystemReqType;
        private String sr_OS = "";
        private String processor = "";
        private uint sr_RAM = 0;
        private String sr_video = "";
        private uint sr_space = 0;

        private SystemReq() { }
        public int IdSystemReqType
        {
            get
            {
                return this.idSystemReqType;
            }
            private set
            {
                this.idSystemReqType = value;
            }
        }
        public int IdSystemReq
        {
            get
            {
                return this.idSystemReq;
            }
            set
            {
                this.idSystemReq = value;
            }
        }
        public int GameId
        {
            get
            {
                return this.game.GameId;
            }
        }
        public Game Game
        {
            get
            {
                return this.game;
            }
            set
            {
                this.game = value;
            }
        }

        public String Sr_OS
        {
            get
            {
                return this.sr_OS;
            }
            private set
            {
                this.sr_OS = value;
            }
        }
        public String Processor
        {
            get
            {
                return this.processor;
            }
            private set
            {
                this.processor = value;
            }
        }
        public uint Sr_RAM
        {
            get
            {
                return this.sr_RAM;
            }
            private set
            {
                this.sr_RAM = value;
            }
        }
        public String Sr_Video
        {
            get
            {
                return this.sr_video;
            }
            private set
            {
                this.sr_video = value;
            }
        }
        public uint Sr_space
        {
            get
            {
                return this.sr_space;
            }
            private set
            {
                this.sr_space = value;
            }
        }
        

        public override string ToString()
        {
            return sr_OS + " " + processor + " " + sr_RAM + " " + sr_video + " " + sr_space;
        }
        public class ReqBuilder
        {
            SystemReq systemReq;
            public ReqBuilder()
            {
                systemReq = new SystemReq();
            }
            public ReqBuilder idSystemReqType(int idSystemReqType)
            {
                systemReq.idSystemReqType = idSystemReqType;
                return this;
            }
            public ReqBuilder idSystemReq(int idSystemReq)
            {
                systemReq.idSystemReq = idSystemReq;
                return this;
            }
            public ReqBuilder game(Game game)
            {
                systemReq.game = game;
                return this;
            }
            public ReqBuilder sr_OS(String sr_OS)
            {
                systemReq.sr_OS = sr_OS;
                return this;
            }
            public ReqBuilder processor(String processor)
            {
                systemReq.processor = processor;
                return this;
            }
            public ReqBuilder sr_RAM(uint sr_RAM)
            {
                systemReq.sr_RAM = sr_RAM;
                return this;
            }
            public ReqBuilder sr_video(String sr_video)
            {
                systemReq.sr_video = sr_video;
                return this;
            }
            public ReqBuilder sr_space(uint sr_space)
            {
                systemReq.sr_space = sr_space;
                return this;
            }
            public SystemReq Build()
            {
                return systemReq;
            }
        }
    }
}
