using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.SOLID.LSP
{
    public class Square : Rectangle   
    {
       public override double Height { get => Height; set => Height = Width = value; }
       public override double Width { get => Width; set => Width = Height = value;} 
    }
}