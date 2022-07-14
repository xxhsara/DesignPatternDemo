using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DrinkDto
{
    public class LongBlack : Coffee
    {
        public LongBlack()
        {
            this.Description = "美式咖啡";
            this.Price = 5;
        }
    }
}
