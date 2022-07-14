using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DrinkDto
{
    public class Decaf : Coffee
    {
        public Decaf()
        {
            this.Description = "无因咖啡";
            this.Price = 1;
        }
    }
}
