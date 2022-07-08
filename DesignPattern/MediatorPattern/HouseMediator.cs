using MediatorPattern.LandLady;
using MediatorPattern.Tentant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class HouseMediator
    {
        public void ShowMessageToTenant(string message, ALandLady landLady)
        {

            var tenantA = new TenantA();
            tenantA.ReceiveMessage(message);


            var tenantB = new TenantB();
            tenantB.ReceiveMessage(message);


        }

        public void ShowMessageToLandLay(string message, ATenant tenant)
        {

            var landlayA = new LandLadyA();
            landlayA.ReceiveMessage(message);



            var landlayB = new LandLadyB();
            landlayB.ReceiveMessage(message);

        }
    }
}
