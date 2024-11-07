// See https://aka.ms/new-console-template for more information
using person;


int Age;
string Name;

Age = 35;
Name = "tiko";

Person person = new Person(Age, Name);

Person person2 = person;
person2.Age = 37;
person2.Name = "niko";

Console.WriteLine(person2.Age);
Console.WriteLine(person2.Name);
