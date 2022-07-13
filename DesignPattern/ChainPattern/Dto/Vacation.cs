using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern.Dto
{
    /// <summary>
    /// 请假单
    /// </summary>
    public class Vacation
    {
        /// <summary>
        /// 请假人
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 请假时间
        /// </summary>
        public int Hour { get; set; }
    }
}
