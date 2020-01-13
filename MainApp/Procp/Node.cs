using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    [Serializable]
    public class Node
    {
        public Node next;
        public List<Baggage> baggage { get; set; }
        public bool IsFree { get; set; }
        public string Name { get; set; }
        public int NumberOfBaggages { get; set; }


        public Node()
        {
            baggage = new List<Baggage>();

        }
    }
}
