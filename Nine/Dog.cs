using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nine
{
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}