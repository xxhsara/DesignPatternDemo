using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    /// <summary>
    /// 热水器
    /// </summary>
    public class Heater : AObserver
    {
        public override void Start()
        {
            Console.WriteLine("Start the Heater");
        }
    }
}
