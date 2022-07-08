using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.LandLady
{
    public abstract class ALandLady
    {
        public HouseMediator houseMediator = new HouseMediator();
        public abstract void SendMessage();

        public abstract void ReceiveMessage(string message);
    }
}
