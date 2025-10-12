using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nine
{
    public interface IVehicle
    {
        string Model { get; set; }
        int Year { get; set; }
        void Start();
    }
}