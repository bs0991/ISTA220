﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Motorcycle : Vehicle
    {
        internal void Accelerate()
        {
            Console.WriteLine("Speeding up");
        }

        internal void Brake()
        {
            Console.WriteLine("Slowing down");
        }
        public override void Drive()
        {
            Console.WriteLine("Riding");
        }

    }
}
