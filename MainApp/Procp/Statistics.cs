using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    [Serializable]
    class Statistics
    {
        public string DropOff1Bags { get; set; }
        public string DropOff1CheckIns { get; set; }
        public string DropOff1Passengers { get; set; }

        public string DropOff2Bags { get; set; }
        public string DropOff2CheckIns { get; set; }
        public string DropOff2Passengers { get; set; }

        public string DropOff3Bags { get; set; }
        public string DropOff3CheckIns { get; set; }
        public string DropOff3Passengers { get; set; }

        public Statistics()
        {

        }
    }
}
