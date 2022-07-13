// See https://aka.ms/new-console-template for more information
using ChainPattern;
using ChainPattern.Dto;

Console.WriteLine("开始请假流程");
var employee = new Employee();
employee.Name = "打工人";
var relationship = new RelationShip();
relationship.InitRelationShip();

while(true)
{
    Console.WriteLine("请输入请假时间:");
    var hour = Console.ReadLine();
    var vacation=employee.ApplyVacation(Convert.ToInt32(hour));
    relationship.baseAuditor.Audit(vacation);
}
