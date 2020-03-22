using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{

    public class Order
    {
        public Customer customer; //客户
        public string orderTime; //订单时间
        public List<OrderItem> itemList; //订单明细
        public int orderNo; //订单号
        public Order(Customer customer1, int orderNo1, List<OrderItem> itemList1)
        {
            this.customer = customer1;
            this.itemList = itemList1;
            this.orderNo++;
        }

        public int TotalPrice()
        {
            int total = 0;
            foreach (OrderItem item in itemList)
                total += item.price * item.goodsNumber;
            return total;
        }

        public override string ToString()
        {
            string items = "";
            foreach (OrderItem item in itemList)
                items += item;
            return $"订单号:{orderNo};\t{items};\t商品总价:{TotalPrice()};\t购买客户:{customer.customerName}";
        }


    }

    
}
