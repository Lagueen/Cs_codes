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
    public partial class Form1 : Form
    {
        private OrderService orderService = new HomeWork8.OrderService();
        private string[] serachMod = { "按订单号查询", "按客户名查询", "按商品名查询" };
        private List<Order> searchResult=new List<Order>();
        private List<OrderItem> resultItems=new List<OrderItem>();
        /*
         * 测试数据绑定
         */
        //private Order[] ors = new Order[20]; 
        //private List<OrderItem> searchItems = new List<OrderItem>();
        public Form1()
        {
           // orders.Add(new Order());
            InitializeComponent();
            resultBindingSource.DataSource = searchResult;
            dataGridView1.DataSource = resultBindingSource;
            itemBindingSource.DataSource = resultItems;
            dataGridView2.DataSource = itemBindingSource;
            this.searchType.Items.AddRange(this.serachMod);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (searchType.SelectedItem)
                {
                    case "按订单号查询":
                        searchResult.Clear();
                        int num = Int32.Parse(textBox1.Text);
                        searchResult.AddRange(orderService.SearchOrderNum(num).ToList<Order>());
                        //itemBindingSource.DataSource = searchResult[dataGridView1.CurrentRow.Index].orderItems;
                        break;
                    case "按商品名查询":
                        searchResult.Clear();
                        searchResult.AddRange(orderService.SearchItemName(textBox1.Text).ToList<Order>());
                        //itemBindingSource.DataSource = searchResult[dataGridView1.CurrentRow.Index].orderItems;
                        break;
                    case "按客户名查询":
                        searchResult.Clear();
                        searchResult.AddRange(orderService.SearchCustomer(textBox1.Text).ToList<Order>());
                        //itemBindingSource.DataSource = searchResult[dataGridView1.CurrentRow.Index].orderItems;
                        break;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                resultBindingSource.ResetBindings(true);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            new AddAndModifyForm(null, orderService).ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                resultItems.AddRange(searchResult[dataGridView1.CurrentRow.Index].orderItems);
                itemBindingSource.ResetBindings(true);
            }
            catch(Exception ex)
            {
                MessageBox.Show("不存在此项");
            }
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                orderService.DeleteOrder(searchResult[dataGridView1.CurrentRow.Index].OrderNum);
                MessageBox.Show("删除成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show("删除失败");
            }
        }


        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(orderService.orders[searchResult[dataGridView1.CurrentRow.Index].OrderNum].ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("打印失败");
            }
        }
    }
}
