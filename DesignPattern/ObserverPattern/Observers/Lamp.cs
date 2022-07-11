using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    public class Lamp : AObserver
    {
        public override void Start()
        {
            Console.WriteLine("Open the lamp");
        }
    }
}
