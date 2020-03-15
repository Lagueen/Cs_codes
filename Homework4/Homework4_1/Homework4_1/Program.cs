using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_1
{
    class Program
    {

        delegate void Func(string n);

        static void Main(string[] args)
        {

            List<string> words = new List<string>(){
            "Apple", "Banana", "Orange", "Mango"
            };
            int letters = 0;

            //匿名方法
            Func printf1 = delegate (string s) {
                Console.WriteLine(s);
            };
            //lambda表达式
            Func printf = s => Console.WriteLine(s);
            foreach (string s in words)
            {
                printf(s);
            }
            //简写为
            words.ForEach(s => Console.WriteLine(s));

            //使用内置委托类型
            Action<string> action = delegate (string s) {
                Console.WriteLine(s);
            };
            words.ForEach(action);

            //匿名方法(使用局部变量)
            Func count = delegate (string s) {
                letters += s.Length;
            };

            foreach (string s in words)
            {
                count(s);
            }
            Console.WriteLine(letters);

            //lambda表达式
            words.ForEach(s => letters += s.Length);
            Console.WriteLine(letters);


            //打印链表元素
            List<int> list = new List<int>();
            for (int x = 0; x < 10; x++)
            {
                list.Add(x);
            }
            //逐个打印
            list.ForEach(x => Console.WriteLine(x));
            //求和
            int sum = 0;
            list.ForEach(x=> { sum += x; });
            Console.WriteLine(sum);
            //求最大值
            int max = int.MinValue;
            list.ForEach(x => { if (max < x) max = x; });
            Console.WriteLine($"最大值：{max}");
            //求最小值
            int min = int.MaxValue;
            list.ForEach(x => { if (min > x) min = x; });
            Console.WriteLine($"最小值：{min}");
        }
    }
}
