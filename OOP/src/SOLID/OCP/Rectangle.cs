using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.SOLID.OCP
{
    public class Rectangle : Shapes
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}