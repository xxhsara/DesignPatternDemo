using DecoratorPattern.DrinkDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorDto
{
    public class Sugar : Decorator
    {
        public Sugar(Drink drink) : base(drink)
        {
            this.Description = "糖";
            this.Price = 1;
        }
    }
}
