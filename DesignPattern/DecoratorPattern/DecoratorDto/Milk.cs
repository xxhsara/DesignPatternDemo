using DecoratorPattern.DrinkDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorDto
{
    public class Milk : Decorator
    {
        public Milk(Drink drink) : base(drink)
        {
            this.Description = "牛奶";
            this.Price = 2;
        }
    }
}
