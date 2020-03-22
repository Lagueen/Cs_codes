using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            service.OrderManaging(service);
            Environment.Exit(0);
        }
    }
}
