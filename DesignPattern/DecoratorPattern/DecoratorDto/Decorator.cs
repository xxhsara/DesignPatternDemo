using DecoratorPattern.DrinkDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DecoratorDto
{
    public class Decorator : Drink
    {
        private Drink _drink;
        public Decorator(Drink drink)
        {
            _drink = drink;
            this.Description = $"{base.Description} && {drink.Description}";
        }

        public override decimal Cost()
        {
            return base.Price + _drink.Cost();
        }
    }
}
