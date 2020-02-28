using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[99];
            for(int i=0;i<99;i++)
            {
                a[i] = i + 2;
            }
            for (int j = 2; j <= 10; j++)
            {
                for (int i = 0; i < 99; i++)
                {
                    if ((a[i] % j == 0) && (a[i] != j))
                        a[i] = 0;
                }
            }
            foreach(int i in a)
            {
                if (i != 0)
                    Console.Write(i + " ");
            }
        }
    }
}
