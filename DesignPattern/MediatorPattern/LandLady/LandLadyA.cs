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
    public class LandLadyA : ALandLady
    {
        
        public override void SendMessage()
        {
            houseMediator.ShowMessageToTenant("我是XXX房子的房东A，我有好多房子租",this);
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"我是房东A，我收到了{message}消息");
        }
    }
}
