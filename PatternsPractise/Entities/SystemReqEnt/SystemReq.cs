using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.Entities
{
    public class SystemReq
    {
        private Game game;
        private String sr_OS = "";
        private String processor = "";
        private uint sr_RAM = 0;
        private String sr_video = "";
        private uint sr_space = 0;

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
