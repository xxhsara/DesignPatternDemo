using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class CProvider : IProvider
    {
        public void Feedback()
        {
            Console.WriteLine("这里是C客户回传实现");
        }

        public void Received()
        {
            throw new NotImplementedException();
        }
    }
}
