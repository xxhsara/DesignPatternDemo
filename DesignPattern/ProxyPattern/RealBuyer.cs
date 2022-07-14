using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealBuyer : IBuyer
    {
        public void Buy()
        {
            Console.WriteLine("我要买苹果手机，电脑，护肤品");
        }
    }
}
