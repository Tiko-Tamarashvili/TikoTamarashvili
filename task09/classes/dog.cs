using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;

namespace Dogs
{
    public class Dog : Animal
    {
        public override string Name { get; set; }
        public override int Age { get; set; }

        public override string makeSound()
        {
            return "Woof";
        }

        public Dog(string name, int age) : base(name, age)
        {
            {
                Name = name;
                Age = age;
            }

        }
    }
}
