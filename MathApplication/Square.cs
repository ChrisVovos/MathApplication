using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{

    public class Square : Rectangle
    {
        public static new int Count { get; protected set; } = 0;
        public Square(double side) : base(side, side)
        {
            Count++;
            Name = Constants.SquareName;
        }
    }
}
