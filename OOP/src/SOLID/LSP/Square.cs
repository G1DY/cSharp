using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP.src.SOLID.LSP
{
    public class Square : Rectangle   
    {
       public override double Height { get => base.Height; set => base.Height = base.Width = value; }
       public override double Width { get => base.Width; set => base.Width = base.Height = value;} 
    }
}