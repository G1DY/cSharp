using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.Polymorphism
{
    public class Plane : Vehicle
    {
        public override void Start()
        
        {
            System.Console.WriteLine("Plane is Starting....");
        }
        public override void Stop()
        {
            System.Console.WriteLine("Plane isStopping...");
        }
    }
}