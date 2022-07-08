using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Tentant
{
    /// <summary>
    /// 租客B
    /// </summary>
    public class TenantB : ATenant
    {
        public override void SendMessage()
        {
            houseMediator.ShowMessageToLandLay("房东好，我是租客B",this);
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"我是租客B,我收到了{message}消息");
        }
    }
}
