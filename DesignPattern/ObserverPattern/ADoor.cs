using ObserverPattern.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class ADoor
    {
        public List<AObserver> aObservers=new List<AObserver>();
        public abstract void Open();

        public void AddObserver(AObserver aObserver)
        {
            aObservers.Add(aObserver);
        }

        public void DeleteObserver(AObserver aObserver)
        {
            aObservers.Remove(aObserver);
        }

        public void NotifyAllObserver()
        {
            foreach(var item in aObservers)
            {
                item.Start();
            }
        }
    }
}
