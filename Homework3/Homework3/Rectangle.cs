using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Rectangle : Geometry
    {
        double length, width;
        public double area;
        public Rectangle(double l,double w)
        {
            this.length = l;
            this.width = w;
        }
        public bool IsQualified()
        {
            if (length > 0 && width > 0)
                return true;
            else
                return false;
        }
        public void GetArea()
        {
            this.area = width * length;
            if (this.IsQualified())
                Console.WriteLine("生成了一个矩形，面积为" + this.area + "。");
            else
            {
                Console.WriteLine("该长方形不合格,因此无法计算面积。");
            }
        }
    }
}
