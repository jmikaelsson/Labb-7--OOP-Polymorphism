using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_7___OOP_Polymorphism
{
    internal class Cirkel : Geometri
    {
        public double Radius { get; set; }

        public Cirkel()
        {
            Radius = 1;
        }
       

        public override double Area()
        {
            return Math.Pow(Radius, 2)*Pi;
        }
    }

}
