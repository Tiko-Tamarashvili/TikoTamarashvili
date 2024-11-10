using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAnimals;

namespace Animals
{
    public abstract class Animal : IAnimal
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }

        public abstract string makeSound();

        protected Animal(string name,int age)
            {
                Name = name;
                Age = age;
            }
    }
}
