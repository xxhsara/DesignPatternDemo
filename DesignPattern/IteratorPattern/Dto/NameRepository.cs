using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Dto
{
    public class NameRepository : Container
    {
        string[] Names;

        public NameRepository()
        {
            Names = new string[3] { "a", "b", "c" };
        }

        public Iterator GetIterator()
        {
            return new NameIterator(Names);
        }
    }
}
