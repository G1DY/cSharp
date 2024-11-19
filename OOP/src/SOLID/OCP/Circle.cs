using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.SOLID.OCP
{
    public class Circle : Shapes
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}