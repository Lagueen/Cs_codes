using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Triangle:Geometry
    {
        double length1, length2, length3;
        public double area;
        public Triangle(double l1,double l2,double l3)
        {
            this.length1 = l1;
            this.length2 = l2;
            this.length3 = l3;
        }

        public bool IsQualified()
        {
            if (length1 > 0 && length2 > 0 && length3 > 0 && (length1 + length2 > length3) && (length2 + length3 > length1) && (length1 + length3 > length2))
                return true;
            else
                return false;
        }
        public void GetArea()
        {
            double p = (length1 + length2 + length3) / 2;
            this.area = Math.Sqrt(p * (p - length1) * (p - length2) * (p - length3));
            if (this.IsQualified())
                Console.WriteLine("生成了一个三角形，面积为" + this.area+"。");
            else 
                Console.WriteLine("该三角形不合格,因此无法计算面积。");   
        }
    }
}
