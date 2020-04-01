using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Homework5
{
    class OrderException : Exception
    {
        private readonly string erroinfo;
        public OrderException(string info) : base(info) { }
    }
    public class Customer
    {
        public string customerName;
        public Customer() { }
        public Customer(string cN)
        {
            this.customerName = cN;
        }

        public override string ToString()
        {
            return customerName;
        }
    }

    public class OrderService
    {
        public List<Order> orderList = new List<Order>();
        public void AddOrder(Customer customer, List<OrderItem> items)
        {
            int count = 0;
            foreach (Order order in orderList)
                count++;
            orderList.Add(new Order(customer, count+1, items));
        }

        public Order SearchOrderNum(int num)
        {
            var order = orderList.Where(or => or.orderNo == num)
                .OrderBy(or => or.TotalPrice());
            Order[] orderList1 = order.ToArray<Order>();
            if (orderList1.Length == 0)
                throw new OrderException("无此订单");
            return orderList1[0];
        }

        private static void Foreach(Order[] orderlist, Action<Order> action)
        {
            for (int i = 0; i < orderlist.Length; i++)
                action(orderlist[i]);
        }

        public Order[] SearchItemName(string name)
        {
            var order = orderList.Where(or => or.itemList.Contains(new OrderItem(name, 0, 0)))
                .OrderBy(or => or.TotalPrice());
            Order[] orderList1 = order.ToArray<Order>();
            if (orderList1.Length == 0)
                throw new OrderException("无此订单");
            Foreach(orderList1, m => Console.WriteLine(m));
            return orderList1;
        }

        public Order[] SearchCustomer(string cusname)
        {
            var order = orderList.Where(or => or.customer.customerName == cusname)
                .OrderBy(or => or.TotalPrice());
            Order[] orderList1 = order.ToArray<Order>();
            if (orderList1.Length == 0)
                throw new OrderException("无此订单");
            Foreach(orderList1, m => Console.WriteLine(m));
            return orderList1;
        }

        public void DeleteOrder(int num)
        {
            if (orderList[num-1] == null)
                throw new OrderException("无此订单");
            orderList.Remove(orderList[num-1]);
        }
        
        //public void AlterOrder(int num)//修改订单
        //{
        //    if (orderList[num] == null)
        //        throw new OrderException("无此订单");
        //   orderList.Remove(orderList[num]);
        //}

        public void SetOrderNum(int prenum, int num)
        {
            Order order = SearchOrderNum(prenum);
            for (int i = 0; i < orderList.Count; i++)
                if (orderList[i].orderNo == num)
                    throw new OrderException("订单号已存在");
            order.orderNo = num;
        }

        public void OrderManaging(OrderService service1)
        {
            bool flag = true;
            Console.WriteLine("请输入客户名:");
            string cusname = Console.ReadLine();
            Customer customer = new Customer(cusname);
            while (flag)
            {   
                Console.WriteLine("请选择功能：添加订单；删除订单；查找订单；设置订单；退出系统。");
                string mod = Console.ReadLine();
                switch (mod)
                {
                    case "添加订单":
                        List<OrderItem> orderItems = new List<OrderItem>();
                        while (true)
                        {
                            Console.WriteLine("请输入商品名称:");
                            string goodsname = Console.ReadLine();
                            Console.WriteLine("请输入商品数量:");
                            int goodsnum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入商品单价(简化自定义):");
                            int goodsprice = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("是否购买其他商品：是/否");
                            string isContimue = Console.ReadLine();
                            if (isContimue == "是")
                            {
                                orderItems.Add(new OrderItem(goodsname, goodsnum, goodsprice));
                            }
                            else if (isContimue == "否")
                            {
                                orderItems.Add(new OrderItem(goodsname, goodsnum, goodsprice));
                                service1.AddOrder(customer ,orderItems);
                                break;
                            }
                        }
                        break;
                    case "删除订单":
                        while (true)
                        {
                            Console.WriteLine("请输入订单号:");
                            int ornum = Int32.Parse(Console.ReadLine());
                            service1.DeleteOrder(ornum);
                            Console.WriteLine("是否继续删除:是/否");
                            string flag1 = Console.ReadLine();
                            if (flag1 == "是")
                                continue;
                            else if (flag1 == "否")
                                break;
                        }
                        break;
                    case "查找订单":
                        while (true)
                        {
                            Console.WriteLine("请输入查找模式：订单号查找/商品名查找/客户名查找");
                            string mode = Console.ReadLine();
                            if (mode == "订单号查找")
                            {
                                Console.WriteLine("请输入订单号:");
                                int num = Int32.Parse(Console.ReadLine());
                                Console.WriteLine(service1.SearchOrderNum(num));
                            }
                            else if (mode == "商品名查找")
                            {
                                Console.WriteLine("请输入商品名:");
                                string name = Console.ReadLine();
                                Console.WriteLine(service1.SearchItemName(name));
                            }
                            else if (mode == "客户名查找")
                            {
                                Console.WriteLine("请输入客户名:");
                                string name = Console.ReadLine();
                                Console.WriteLine(service1.SearchCustomer(name));
                            }
                            Console.WriteLine("是否继续查找:是/否");
                            string flag1 = Console.ReadLine();
                            if (flag1 == "是")
                                continue;
                            else if (flag1 == "否")
                                break;
                        }
                        break;
                    case "设置订单":
                        while (true)
                        {
                            Console.WriteLine("请输入订单号:");
                            int ornum = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入修改后的订单号");
                            int ornum1 = Int32.Parse(Console.ReadLine());
                            service1.SetOrderNum(ornum, ornum1);
                            Console.WriteLine("是否继续修改:是/否");
                            string flag1 = Console.ReadLine();
                            if (flag1 == "是")
                                continue;
                            else if (flag1 == "否")
                                break;
                        }
                        break;
                    case "退出系统":
                        flag = false;
                        break;
                    default: Console.WriteLine("无此功能"); break;
                }
            }          
        }

        public void Export()
        {
            Order[] orders = orderList.ToArray();
            Console.WriteLine("original array object:");
            Array.ForEach(orders, ord => Console.WriteLine(ord));

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream("orders.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }

            Console.WriteLine("\nSerialized as XML:");
            Console.WriteLine(File.ReadAllText("orders.xml"));

        }

        public void Import(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                temp.ForEach(order => {
                    if (!orderList.Contains(order))
                    {
                        orderList.Add(order);
                    }
                });
            }
        }


    }
}

