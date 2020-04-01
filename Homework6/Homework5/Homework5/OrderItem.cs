using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
   
    public class OrderItem
    {
        public string goodsName { set; get; }
        public int goodsNumber { set; get; }
        public int price { set; get; } //订购商品列表

        public OrderItem() { }
        public OrderItem(string goodsname,int goodsnumber,int price1)
        {
            this.goodsName = goodsname;
            this.goodsNumber = goodsnumber;
            this.price = price1;
        }
        public override string ToString()
        {
            return $"商品名称:{goodsName}\t购买数量:{goodsNumber};\t商品单价:{price}\n";
        }
        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            return orderItem != null && goodsName == orderItem.goodsName;
        }
    }
}
