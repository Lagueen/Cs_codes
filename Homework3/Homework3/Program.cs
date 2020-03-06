using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            double sumArea = 0;
            for (int i = 0; i < 10; i++)
            {
                int tmp = random.Next(1, 4);
                switch (tmp)
                {
                    case 1:
                        Random random1 = new Random(Guid.NewGuid().GetHashCode());
                        Rectangle rectangle = new Rectangle(random1.Next(0, 10), random1.Next(0, 10));
                        rectangle.GetArea();
                        Console.WriteLine();
                        if (rectangle.IsQualified())
                            sumArea += rectangle.area;
                        break;
                    case 2:
                        Random random2 = new Random(Guid.NewGuid().GetHashCode());
                        Square square = new Square(random2.Next(0, 10));
                        square.GetArea();
                        Console.WriteLine();
                        if (square.IsQualified())
                            sumArea += square.area;
                        break;
                    case 3:
                        Random random3 = new Random(Guid.NewGuid().GetHashCode());
                        Triangle triangle = null;
                        triangle = new Triangle(random3.Next(0, 10), random3.Next(1, 10), random3.Next(1, 10));
                        triangle.GetArea();
                        Console.WriteLine();
                        if (triangle.IsQualified())
                            sumArea += triangle.area;
                        break;
                }
            }
            Console.WriteLine("总面积为：" + sumArea);
        }
    }
}
