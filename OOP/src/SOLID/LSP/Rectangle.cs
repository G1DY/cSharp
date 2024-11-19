using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.SOLID.LSP
{
    public class Rectangle : Shapes
    {
        public virtual double Height { get; set; }  
        public virtual double Width { get; set;}
        public override double Area => Height * Width;
    }
}