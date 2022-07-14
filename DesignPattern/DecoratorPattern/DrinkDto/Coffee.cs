using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DrinkDto
{
    public class Coffee : Drink
    {
        public override decimal Cost()
        {
            return base.Price;
        }
    }
}
