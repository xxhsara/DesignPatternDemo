// See https://aka.ms/new-console-template for more information
//点一杯美式咖啡
using DecoratorPattern.DecoratorDto;
using DecoratorPattern.DrinkDto;

Drink longblack = new LongBlack();
Console.WriteLine($"{longblack.Description};金额：{longblack.Cost()}");

//添加的牛奶
longblack = new Milk(longblack);

Console.WriteLine($"添加了{longblack.Description};金额：{longblack.Cost()}");