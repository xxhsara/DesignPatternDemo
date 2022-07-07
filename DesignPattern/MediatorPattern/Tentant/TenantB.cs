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
    public class TenantB : ITenant
    {
        public void SendMessage()
        {
            Console.WriteLine("房东好，我是租客B");
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"我是租客B,我收到了{message}消息");
        }
    }
}
