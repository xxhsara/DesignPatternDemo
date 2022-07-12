using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observers
{
    /// <summary>
    /// 空调
    /// </summary>
    public class Airconditioner : AObserver
    {
        public override void Start()
        {
            Console.WriteLine("Start the Airconditioner");
        }
    }
}
