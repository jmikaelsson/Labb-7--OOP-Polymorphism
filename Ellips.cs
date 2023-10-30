using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        public double RadiusA { get; set; }
        public double RadiusB { get; set; }

        public Ellips()
        {
            RadiusA = 4;
            RadiusB = 6;

        }


        public override double Area()
        {
            
            return RadiusA*RadiusB*Pi;
        }
    }
}
