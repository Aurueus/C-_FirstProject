using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nine
{
    public class Car : IVehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Model} ({Year}) started\nwroom-wroom");
        }
    }
}