using StatePattern.Observers;
using StatePattern.State;

namespace StatePattern
{

    /// <summary>
    /// 状态使用类
    /// </summary>
    public class TraficLampContext
    {
        private ITrafficLampState state;
        private List<AObserver> _observerList;

        public TraficLampContext()
        {
            state = null;
            _observerList = new List<AObserver>();
        }
        public ITrafficLampState GetLampState()
        {
            return state;
        }

        public List<AObserver> GetObservers()
        {
            return _observerList;
        }

        public void SetLampState(ITrafficLampState lampState)
        {
            this.state = lampState;
        }

        public void AddObserver(AObserver observer)
        {
            _observerList.Add(observer);
        }
        public void RemoveObserver(AObserver observer)
        {
            _observerList.Remove(observer);
        }


    }
}
