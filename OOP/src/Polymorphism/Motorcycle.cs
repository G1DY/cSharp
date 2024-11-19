using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.Polymorphism
{
    public class Motorcycle : Vehicle
    {
        public override void Start()
        {
            System.Console.WriteLine("Motorcycle is Starting....");
        }
        public override void Stop()
        {
            System.Console.WriteLine("Motorcycle is Stopping...");
        }
    }
}