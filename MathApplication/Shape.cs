using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    public abstract class Shape 
    {

        public string Name { get; protected set; }

        public abstract double SurfaceArea();
        public abstract double Perimeter();
        public override string ToString()
        {
            return Name+" Area is :" + SurfaceArea() + ", " + "Perimeter is : " + Perimeter();
        }
    }
  
}
