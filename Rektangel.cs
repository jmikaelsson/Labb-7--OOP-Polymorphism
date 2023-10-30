using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___OOP_Polymorphism
{
    internal class Rektangel : Geometri
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rektangel ()
        {
            Height = 8;
            Width = 12;
        }
        public override double Area()
        {
            return Height * Width;
        }
    }
}
