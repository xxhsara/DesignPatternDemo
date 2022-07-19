namespace StatePattern.State
{
    public class YellowState : ITrafficLampState
    {
        public void DoAction(TraficLampContext traficLampContext)
        {
            traficLampContext.SetLampState(this);
            Console.WriteLine("交通灯变黄了！");
            var observers=traficLampContext.GetObservers();
            foreach(var item in observers)
            {
                item.DoYellosAction();
            }
        }
    }
}
