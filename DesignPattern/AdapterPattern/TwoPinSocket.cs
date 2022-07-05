using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TwoPinSocket : IPin
    {
        public void Charge()
        {
            Console.WriteLine("使用两脚插座充电");
        }
    }
}
