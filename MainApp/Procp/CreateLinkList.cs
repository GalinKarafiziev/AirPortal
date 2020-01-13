using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    [Serializable]
    public class CreateLinkList
    {
        public CheckIn CheckIn { get; set; }
        public Conveyor Conv1 { get; set; }
        public Conveyor Conv2 { get; set; }
        public MainProcessArea MainProcessArea { get; set; }
        public DropOff DropOff { get; set; }
        public LinkedList LinkList { get; set; }



        public CreateLinkList(LinkedList link, CheckIn Check, Conveyor Con1, Conveyor Con2, MainProcessArea Main, DropOff Drop)
        {
            this.LinkList = link;
            this.CheckIn = Check;
            this.Conv1 = Con1;
            this.Conv2 = Con2;
            this.MainProcessArea = Main;
            this.DropOff = Drop;

            LinkList.AddLast(CheckIn);
            LinkList.AddLast(Conv1);
           // LinkList.AddLast(MainProcessArea);
            LinkList.AddLast(Conv2);
            LinkList.AddLast(DropOff);
        }
    }
}
