using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Door : ADoor
    {
        public override void Open()
        {
            Console.WriteLine("Open the Door");
            base.NotifyAllObserver();
        }
    }
}
