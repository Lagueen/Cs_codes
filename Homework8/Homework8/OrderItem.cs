using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    [Serializable]
    public class OrderItem
    {
        public string Name { set; get; }
        public int Number { set; get; }
        public int UnitPrice { set; get; }

        public OrderItem()
        {

        }
        public OrderItem(string name, int number, int price)
        {
            Name = name;
            Number = number;
            UnitPrice = price;
        }

        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            return orderItem != null && Name == orderItem.Name;
        }

        public override string ToString()
        {
            return $"商品名称:{Name};\t购买数量:{Number};\t商品单价:{UnitPrice}";
        }
    }
}
