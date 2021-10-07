using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPractise.Entities
{
    public class SystemReq
    {
        public String sr_OS { set; get; }
        public String processor { set; get; }
        public String sr_RAM { set; get; }
        public String sr_video { set; get; }
        public String sr_space { set; get; }

        public override string ToString()
        {
            String obj = "";
            return obj + sr_OS + " " + processor + " " + sr_RAM + " " + sr_video + " " + sr_space;
        }
    }
}
