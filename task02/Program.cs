// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

Random random = new Random();
int randomNumber = random.Next(1, 10);
int a;
a = Convert.ToInt32(Console.ReadLine());
if (a == randomNumber)
{
    Console.WriteLine("you won");
}
else Console.WriteLine("Try again");
a = Convert.ToInt32(Console.ReadLine());
if (a == randomNumber)
{
    Console.WriteLine("you won");
}
else Console.WriteLine("Try again");
a = Convert.ToInt32(Console.ReadLine());
if (a == randomNumber)
{
    Console.WriteLine("you won");
}

else Console.WriteLine("you lost, correct number is " + randomNumber);

