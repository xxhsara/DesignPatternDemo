using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Dto
{
    public interface Iterator
    {
        bool HasNext();
        Object Next();
    }
}
