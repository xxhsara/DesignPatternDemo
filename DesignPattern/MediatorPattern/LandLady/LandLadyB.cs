using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.LandLady
{
    /// <summary>
    /// 房东
    /// </summary>
    public class LandLadyB
    {
        public void SendMessage()
        {
            Console.WriteLine("我是XXX房子的房东B");
        }

        public void CollectRent()
        {
            Console.WriteLine("房东B开始收房租了");
        }
    }
}
