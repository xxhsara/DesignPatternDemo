using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern.Dto
{
    public class Employee
    {
        public string Name { get; set; }

        public Vacation ApplyVacation(int hour)
        {
            var vacation = new Vacation();
            vacation.Hour = hour;
            vacation.Name = Name;
            return vacation;
        }
    }
}
