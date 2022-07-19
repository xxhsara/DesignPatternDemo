using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Observers
{
    /// <summary>
    /// 司机
    /// </summary>
    public class Driver : AObserver
    {
        public override void DoGreenAction()
        {
            Console.WriteLine("绿灯啦，可以启动啦！");
        }

        public override void DoRedAction()
        {
            Console.WriteLine("红灯啦，要刹车！");
        }

        public override void DoYellosAction()
        {
            Console.WriteLine("黄灯啦，要刹车！");
        }
    }
}
