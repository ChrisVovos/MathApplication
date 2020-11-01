using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(1);
            Console.WriteLine(circle.ToString());

            Triangle triangleOne = new Triangle(1, 2, 3);
            Console.WriteLine(triangleOne.ToString());

            Triangle triangleTwo = new Triangle(2, 2, 2);
            Console.WriteLine(triangleTwo.ToString());

            Triangle triangleThree = new Triangle(2, 2, 3);
            Console.WriteLine(triangleThree.ToString());

            Rectangle rectangle = new Rectangle(2, 2);
            Console.WriteLine(rectangle.ToString());

            Square square = new Square(3);
            Console.WriteLine(square.ToString());

            List<Shape> baseShapes = new List<Shape>();
            baseShapes.Add(circle);
            baseShapes.Add(triangleOne);
            baseShapes.Add(triangleThree);
            baseShapes.Add(rectangle);
            baseShapes.Add(square);

            Console.WriteLine();

            var sortedList = baseShapes.OrderBy(p => p.SurfaceArea());
            PrintShapes(sortedList, "Shapes ordered by Surface Area");

            sortedList = baseShapes.OrderBy(p => p.Perimeter());
            PrintShapes(sortedList, "Shapes ordered by Perimeter");

            string Json = GetJsonString(triangleOne);
            Console.WriteLine("Json is" + Json);

            PrintCountOfShapes();

            Console.ReadLine();
        }

        private static void PrintShapes(IEnumerable<Shape> sortedList, string message)
        {
            Console.WriteLine(message);
            foreach (var baseShape in sortedList)
            {
                Console.WriteLine(baseShape);
            }
            Console.WriteLine();
        }

        public static string GetJsonString(Shape obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static void PrintCountOfShapes()
        {
            Console.WriteLine();
            Console.WriteLine("the number of Circle    is  " + Circle.Count);
            Console.WriteLine("the number of triangle  is  " + Triangle.Count);
            Console.WriteLine("the number of Square    is  " + Square.Count);
            Console.WriteLine("the number of Rectangle is  " + Rectangle.Count);
        }
    }
}
