using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.Polymorphism
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public override void Start()
        
        {
            System.Console.WriteLine("Car is Starting....");
        }
        public override void Stop()
        {
            System.Console.WriteLine("Car isStopping...");
        }
    }
}