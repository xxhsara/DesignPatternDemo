namespace StatePattern.State
{
    /// <summary>
    /// 红灯
    /// </summary>
    public class RedState : ITrafficLampState
    {
        public void DoAction(TraficLampContext traficLampContext)
        {
            traficLampContext.SetLampState(this);
            Console.WriteLine("交通灯变红了！");
            var observers = traficLampContext.GetObservers();
            foreach (var item in observers)
            {
                item.DoRedAction();
            }
        }
    }
}
