﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Car:IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car started!");
        }
    }
}
