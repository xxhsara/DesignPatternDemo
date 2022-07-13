using ChainPattern.Auditor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainPattern
{
    public class RelationShip
    {

        public BaseAuditor baseAuditor { get; private set; }
        public void InitRelationShip()
        {
            var chairMan = new ChairMan();
            chairMan.Name = "谢董事长";

            var director = new Director();
            director.Name = "罗总监";
            director.SetNextAuditor(chairMan);

            var departmentLeader = new DepartmentLeader();
            departmentLeader.Name = "刘经理";
            departmentLeader.SetNextAuditor(director);

            var groupLeader = new GroupLeader();
            groupLeader.Name = "张组长";
            groupLeader.SetNextAuditor(departmentLeader);
            baseAuditor = groupLeader;
        }
    }
}
