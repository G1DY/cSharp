using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.Composition
{
    public class Car
    {
        private Engine engine = new Engine();
        private Chasis chasis= new Chasis();
        private Seat seat= new Seat();
        private Wheel wheel= new Wheel();
    
        public void startCar()
        {
            engine.Start();
            chasis.Work();
            seat.sit();
            wheel.rotate();
            System.Console.WriteLine("The car is starting");

        }
    }
}