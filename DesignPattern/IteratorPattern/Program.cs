// See https://aka.ms/new-console-template for more information

using IteratorPattern.Dto;

var nameRepository = new NameRepository();
var nameiterator=nameRepository.GetIterator();
while(nameiterator.HasNext())
{
    Console.WriteLine(nameiterator.Next().ToString());
}
