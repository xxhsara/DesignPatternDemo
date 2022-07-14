using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class ProxyBuyer : IBuyer
    {
        private readonly RealBuyer _realBuyer = new RealBuyer();
        public void Buy()
        {
            PreBuy();
            _realBuyer.Buy();
            PostBuy();
        }

        /// <summary>
        /// 买之前操作
        /// </summary>
        private void PreBuy()
        {
            Console.WriteLine("买之前列个清单");
        }

        /// <summary>
        /// 买之后操作
        /// </summary>
        private void PostBuy()
        {
            Console.WriteLine("买之后整理一下邮寄出去");
        }
    }
}
