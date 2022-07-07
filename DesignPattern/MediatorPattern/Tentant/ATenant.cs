using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Tentant
{
    public abstract class ATenant
    {
        public abstract void SendMessage();

        public abstract void ReceiveMessage(string message);
    }
}
