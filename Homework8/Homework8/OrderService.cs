using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace HomeWork8
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();
        public void AddOrder(string cusname, List<OrderItem> items)
        {
            int count = 0;
            foreach (Order order in orders)
                count++;
            orders.Add(new Order(count, cusname, items));
        }

        public Order[] SearchOrderNum(int num)
        {
            var order = orders.Where(or => or.OrderNum == num)
                .OrderBy(or => or.TotalPrice);
            Order[] ods = order.ToArray<Order>();
            if (ods.Length == 0)
                throw new OrderException("无此订单");
            return ods;
        }

        public Order[] SearchItemName(string name)
        {
            var order = orders.Where(or => or.orderItems.Contains(new OrderItem(name, 0, 0)))
                .OrderBy(or => or.TotalPrice);
            Order[] ods = order.ToArray<Order>();
            if (ods.Length == 0)
                throw new OrderException("无此订单");
            //Foreach(ods, m => Console.WriteLine(m));
            return ods;
        }

        public Order[] SearchCustomer(string cus)
        {
            var order = orders.Where(or => or.Customer == cus)
                .OrderBy(or => or.TotalPrice);
            Order[] ods = order.ToArray<Order>();
            if (ods.Length == 0)
                throw new OrderException("无此订单");
            //Foreach(ods, m => Console.WriteLine(m));
            return ods;
        }

        public void DeleteOrder(int num)
        {
            Order[] order = SearchOrderNum(num);
            orders.Remove(order[0]);
        }

        public void SetOrderNum(int prenum, int num)
        {
            Order[] order = SearchOrderNum(prenum);
            for (int i = 0; i < orders.Count; i++)
                if (orders[i].OrderNum == num)
                    throw new OrderException("订单号已存在");
            order[0].OrderNum = num;
        }

        public void SetItemName(int num, int itemnum, string name)
        {
            Order[] order = SearchOrderNum(num);
            order[0].orderItems[itemnum].Name = name;
        }

        public void SetItemNum(int num, int item, int itemnum)
        {
            Order[] order = SearchOrderNum(num);
            order[0].orderItems[item].Number = itemnum;
        }

        public void SetItemPrice(int num, int item, int itemprice)
        {
            Order[] order = SearchOrderNum(num);
            order[0].orderItems[item].UnitPrice = itemprice;
        }

        public void SetCusName(int num, string name)
        {
            Order[] order = SearchOrderNum(num);
            order[0].Customer = name;
        }

        public void OrderSort()
        {
            orders.Sort();
        }

        public void Delete(int ordermnum)
        {
            if (orders[ordermnum] == null)
                throw new OrderException("无此订单");
            orders.Remove(orders[ordermnum]);
        }

        private static void Foreach(Order[] orderlist, Action<Order> action)
        {
            for (int i = 0; i < orderlist.Length; i++)
                action(orderlist[i]);
        }

        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("test.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
            Console.WriteLine(File.ReadAllText("test.xml"));
        }

        public void Import(string filepath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filepath, FileMode.Open))
            {
                List<Order> orders1 = (List<Order>)xmlSerializer.Deserialize(fs);
                Order[] ol = orders1.ToArray();
                Foreach(ol, p => Console.WriteLine(p));
            }
        }
    }
}
