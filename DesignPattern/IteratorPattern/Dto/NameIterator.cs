using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Dto
{
    public class NameIterator : Iterator
    {
        public string[] Names;
        public static int Index = 0;

        public NameIterator(string[] names)
        {
            Names = names;
        }
        public bool HasNext()
        {
            if(Index>=Names.Length || Names[Index]==null)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            var name = Names[Index++];
            return name;
        }
    }
}
