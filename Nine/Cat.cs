using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nine
{
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meoooow!");
        }
    }
}