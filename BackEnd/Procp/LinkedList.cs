using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    class LinkedList
    {
        private Node first;

       public List<Baggage> getAllBags()
        {
            return first.baggage;
        }

        public int PartsInLinkedList { get; set; }
        public void printAllNodes()
        {
            Node current = first;
            while (current != null)
            {

                Console.WriteLine(current.Name);
                current = current.next;

                

            }
        }

        public Node GetLast()
        {
            Node current = first;
            while (current.next != null)
            {
                current = current.next;
            }

            return current;

        }

        public void AddLast(Node node)
        {
            if (first != null)
            {
                Node last = GetLast();

                // traverse all nodes (see the print all nodes method for an example)
                last.next = node;
                PartsInLinkedList++;

            }
            else
            {
                first = node;
                PartsInLinkedList++;
            }

        }

        public void PassBaggage(Baggage data)
        {
            Node current = first;
            
            while (current != null)
            {
                if (current is CheckIn)
                {
                    (current as CheckIn).PassBaggage(data);
                    
                }
                if (current is Conveyor)
                {
                    (current as Conveyor).PassBaggage(data);
                    
                }
                if (current is MainProcessArea)
                {
                    (current as MainProcessArea).PassBaggage(data);
                    
                }
                if (current is DropOff)
                {
                    (current as DropOff).PassBaggage(data);
                    current.baggage.Add(data);
                }
                current = current.next;
                
            }


        }
    }
}
