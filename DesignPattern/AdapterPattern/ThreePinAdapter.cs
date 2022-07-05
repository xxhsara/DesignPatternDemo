using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class ThreePinAdapter : IPin
    {
        private ThreePinSocket pinSocket;

        public ThreePinAdapter(ThreePinSocket pinSocket)
        {
            this.pinSocket = pinSocket;
        }

        public void Charge()
        {
            pinSocket.Charge();
        }
    }
}
