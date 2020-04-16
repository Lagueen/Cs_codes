using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork8;

namespace OrderForm
{
    public partial class AddAndModifyForm : Form
    {
        List<OrderItem> orderItems=new List<OrderItem>();
        OrderService orderService;
        public AddAndModifyForm(Order order,OrderService orderService)
        {
            InitializeComponent();
            this.orderService = orderService;
            itemsBindingSource.DataSource = orderItems;
            dataGridView1.DataSource = itemsBindingSource;
            if(order!=null)
            {
                itemsBindingSource.DataSource = order.orderItems;
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.Name = itemNameBox.Text;
            orderItem.UnitPrice = Int32.Parse(priceBox.Text);
            orderItem.Number = Int32.Parse(itemNumBox.Text);
            orderItems.Add(orderItem);
            itemsBindingSource.ResetBindings(true);
            MessageBox.Show("订单项添加成功");
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            List<OrderItem> odi = new List<OrderItem>(orderItems);
            orderService.AddOrder(cusNameBox.Text, odi);
            orderItems.Clear();
            itemsBindingSource.ResetBindings(true);
            MessageBox.Show("订单添加成功");
        }
    }
}
