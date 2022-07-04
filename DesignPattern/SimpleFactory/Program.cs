// See https://aka.ms/new-console-template for more information
using SimpleFactory;

var customerfactory=new CustomerFactory();
var customer=customerfactory.GetCustomerProvider("A");//A这里后续可以写到数据库中，写死客户名称
customer.Feedback();


