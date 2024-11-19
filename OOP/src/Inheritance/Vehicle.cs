using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.Inheritance
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void start()
        {
            System.Console.WriteLine("Starting the vehicle...");
        }
        public void stop()
        {
            System.Console.WriteLine("Stopping the vehicle....");
        }
    }
}