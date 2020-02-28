using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "";
                Console.Write("请输入一个数字:");
                s = Console.ReadLine();
                int num1 = Int32.Parse(s);
                Console.Write("请输入一个运算符:+ - * /:  ");
                s = Console.ReadLine();
                char op = char.Parse(s);
                Console.Write("请输入一个数字：");
                s = Console.ReadLine();
                int num2 = Int32.Parse(s);
                int result = 0;
                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                            Console.WriteLine("除零错误");
                        else
                            result = num1 / num2;
                        break;
                }
                if (num2 != 0)
                    Console.WriteLine($"结果:{result}");
                else
                    Console.WriteLine("出现错误}");
            }
            catch (OverflowException a)
            {
                Console.WriteLine(a);
            }
        }
    }
}
