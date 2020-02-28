using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please input a integer num: ");
            string s = Console.ReadLine();
            int num = Int32.Parse(s);
            int k = 2;
            StringBuilder result = new StringBuilder();
            while (num != 1)
            {
                if (num % k == 0)
                {
                    result.Append(k + " ");
                    num = num / k;
                    k = 2;
                }
                else
                {
                    k++;
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
