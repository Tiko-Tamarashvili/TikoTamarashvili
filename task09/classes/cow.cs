using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;

namespace Cows
{
    public class Cow : Animal
    {
        public override string Name { get; set; }
        public override int Age { get; set; }

        public override string makeSound()
        {
            return "Moo";
        }

        public Cow(string name, int age) : base(name, age)
        {
            {
                Name = name;
                Age = age;
            }

        }
    }
}
