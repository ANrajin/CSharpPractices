﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Bike:IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bike started!");
        }
    }
}