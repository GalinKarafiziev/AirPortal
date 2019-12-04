using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procp
{
    public class CreateLinkList
    {
        CheckIn CheckIn { get; set; }
        Conveyor Conv1 { get; set; }
        Conveyor Conv2 { get; set; }
        MainProcessArea MainProcessArea { get; set; }
        DropOff DropOff { get; set; }
        LinkedList LinkList { get; set; }



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
            LinkList.AddLast(MainProcessArea);
            LinkList.AddLast(Conv2);
            LinkList.AddLast(DropOff);
        }
    }
}
