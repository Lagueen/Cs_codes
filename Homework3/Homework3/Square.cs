using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Square:Geometry
    {
        double side;
        public double area;
        public Square(double eL)
        {
            this.side = eL;
        }

        public bool IsQualified()
        {
            if (side > 0 )
                return true;
            else
                return false;
        }

        public void GetArea()
        {
            this.area = side * side;
            if (this.IsQualified())
                Console.WriteLine("生成了一个正方形，面积为" + this.area + "。");
            else
            {
                Console.WriteLine("该正方形不合格,因此无法计算面积。");
            }
        }
    }
}
