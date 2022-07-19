using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Observers
{
    public abstract class AObserver
    {
        public abstract void DoRedAction();
        public abstract void DoGreenAction();
        public abstract void DoYellosAction();
    }
}
