using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Observers
{
    public class TrafficPolice : AObserver
    {
        public override void DoGreenAction()
        {
            Console.WriteLine("绿灯啦，司机可以开过去啦！");
        }

        public override void DoRedAction()
        {
            Console.WriteLine("红灯啦，看看哪个司机违反交通规则闯红灯");
        }

        public override void DoYellosAction()
        {
            Console.WriteLine("黄灯啦，司机们不要再过了");
        }
    }
}
