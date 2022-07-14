using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DrinkDto
{
    public abstract class Drink
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public abstract decimal Cost();
    }
}
