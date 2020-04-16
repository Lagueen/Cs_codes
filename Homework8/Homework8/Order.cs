using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    [Serializable]
    public class Order:IComparable
    {
        public int OrderNum { set; get; }
        public string Customer { set; get; }
        public List<OrderItem> orderItems;

        public Order()
        {

        }
        public Order(int ordernumber, string customer, List<OrderItem> items)
        {
            OrderNum = ordernumber;
            Customer = customer;
            orderItems = items;
        }

        public int TotalPrice
        {
            get
            {
                int total = 0;
                foreach (OrderItem item in orderItems)
                    total += item.UnitPrice * item.Number;
                return total;
            }
        }
        public override string ToString()
        {
            string items = "";
            foreach (OrderItem item in orderItems)
                items += item;
            return $"订单号:{OrderNum};\t{items};\t商品总价:{TotalPrice};\t购买客户:{Customer}";
        }

        public int CompareTo(Object obj2)
        {
            if (!(obj2 is Order))
                throw new System.ArgumentException();
            Order order2 = obj2 as Order;
            return this.OrderNum.CompareTo(order2.OrderNum);
        }

        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && order.orderItems == this.orderItems && order.OrderNum == this.OrderNum && order.Customer == this.Customer;
        }
    }
}
