using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    public class Triangle : Shape
    {
        public double SideOne { get; private set; }
        public double SideTwo { get; private set; }
        public double SideThree { get; private set; }
        public static int Count { get; private set; } = 0;

        public Triangle(double sideHeight, double sideBase, double sideThree)
        {
            Count++;
            this.SideOne = sideHeight;
            this.SideTwo = sideBase;
            this.SideThree = sideThree;

            if (sideHeight == sideBase && sideBase == sideThree)
            {
                Name = Constants.EquilateralName;
            }
            else if (sideHeight != sideBase && sideBase != sideThree && sideHeight != sideThree)
            {
                Name = Constants.ScaleneName;
            }
            else
            {
                Name = Constants.IsosclelesName;
            }

        }
        public override double Perimeter()
        {
            return SideOne + SideTwo + SideThree;
        }

        public override double SurfaceArea()
        {
            return (SideOne + SideTwo) / 2;
        }
    }
}
