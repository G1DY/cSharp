using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.Polymorphism
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }

        public virtual void Start()
        {
            System.Console.WriteLine("Starting....");
        }
        public virtual void Stop()
        {
            System.Console.WriteLine("Stopping...");
        }

    }
}