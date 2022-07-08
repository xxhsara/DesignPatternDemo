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
    public class LandLadyB : ALandLady
    {
        public HouseMediator houseMediator = new HouseMediator();
        public override void SendMessage()
        {
            houseMediator.ShowMessageToTenant("我是XXX房子的房东B",this);
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"我是房东B，我收到了{message}消息");
        }
    }
}
