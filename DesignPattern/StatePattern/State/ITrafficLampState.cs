namespace StatePattern.State
{
    /// <summary>
    /// 交通灯状态
    /// </summary>
    public interface ITrafficLampState
    {
        void DoAction(TraficLampContext traficLampContext);

       
    }
}
