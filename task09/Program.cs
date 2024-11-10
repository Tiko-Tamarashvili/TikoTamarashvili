using Dogs;
using Animals;
using Cows;
using Cats;

 Animal[] animals = new Animal[3];

Dog dog = new Dog("Linda", 1);
Cow cow = new Cow("Wiqara", 2);
Cat cat = new Cat("Faraon", 3);

animals[0] = dog;
animals[1] = cow;
animals[2] = cat;


for (int i = 0; i < animals.Length; i++)
{
    Console.WriteLine(animals[i].GetType().Name + " Says " + animals[i].makeSound());
}
