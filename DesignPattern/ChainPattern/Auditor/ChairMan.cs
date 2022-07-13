using ChainPattern.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern.Auditor
{
    /// <summary>
    /// 董事长
    /// </summary>
    public class ChairMan : BaseAuditor
    {
        public override void Audit(Vacation vacation)
        {
            if(vacation.Hour<360)
            {
                Console.WriteLine($"{vacation.Name}请假{vacation.Hour}小时,{Name}审核通过");
            }
            else
            {
                if(NextAuditor!=null)
                {
                    NextAuditor.Audit(vacation);
                }
                else
                {
                    Console.WriteLine("请假时间太长，无法审批");
                }
            }
        }
    }
}
