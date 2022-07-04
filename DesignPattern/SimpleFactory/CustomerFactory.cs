using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class CustomerFactory
    {
        public IProvider? GetCustomerProvider(string shapetype)
        {
            switch (shapetype)
            {
                case "A":
                    return new AProvider();
                case "C":
                    return new CProvider();
                case "B":
                    return new BProvider();
                default:
                    return null;
            }
        }
    }
}
