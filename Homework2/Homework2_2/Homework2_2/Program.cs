using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 6, 7, 13, 52, 4, 38, 95, 10, 58 };
            int max, min, total;
            double average;
            void ArrayOp(int []a,out int max1,out int min1,out int total1,out double average1)
            {
                max1 = a[0]; min1 = a[0]; total1 = 0;
                for(int i = 0; i < 10; i++)
                {
                    if (max1 < a[i])
                        max1 = a[i];
                }
                for (int i = 0; i < 10; i++)
                {
                    if (min1 > a[i])
                        min1 = a[i];
                }
                for (int i = 0; i < 10; i++)
                {
                    total1 += a[i];
                }
                average1 = (double)total1 / 10;
            }
            ArrayOp(array,out max,out min,out total,out average);
            Console.WriteLine($"最大值：{max},最小值:{min},总和:{total},平均数:{average}");

           
        }
    }
}
