namespace StatePattern.State
{
    public class GreenState : ITrafficLampState
    {
        public void DoAction(TraficLampContext traficLampContext)
        {
            traficLampContext.SetLampState(this);
            Console.WriteLine("交通灯变绿了！");
            var observers = traficLampContext.GetObservers();
            foreach (var item in observers)
            {
                item.DoGreenAction();
            }
        }
    }
}
