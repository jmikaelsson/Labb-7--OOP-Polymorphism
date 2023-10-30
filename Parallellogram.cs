using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___OOP_Polymorphism
{
    internal class Parallellogram : Geometri
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Parallellogram()
        {
            Height = 4;
            Width = 3;
        }
        public override double Area()
        {
            
            return Height * Width;
        }
    }
}
