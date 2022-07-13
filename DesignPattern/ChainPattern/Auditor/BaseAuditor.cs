using ChainPattern.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern.Auditor
{
    public abstract class BaseAuditor
    {
        public BaseAuditor NextAuditor { get; private set; }
        public string Name { get; set; }
        public abstract void Audit(Vacation vacation);

        public void SetNextAuditor(BaseAuditor nextAuditor)
        {
            NextAuditor = nextAuditor; 
        }
    }
}
