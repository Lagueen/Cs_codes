using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService service = new OrderService();
        Customer customer = new Customer("Lagueen");
        [TestMethod()]
        public void AddOrderTest()
        {
            List<Order> orderList = new List<Order>();
            List<OrderItem> items = new List<OrderItem>();
            OrderItem item = new OrderItem("鞋子", 2, 300);
            items.Add(item);
            Order order1 = new Order(customer, 1, items);
            orderList.Add(order1);
            service.AddOrder(customer, items);
            CollectionAssert.Equals(orderList, service.orderList);
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            List<Order> orderList = new List<Order>();
            List<OrderItem> items = new List<OrderItem>();
            OrderItem item = new OrderItem("鞋子", 2, 300);
            items.Add(item);
            Order order1 = new Order(customer, 1, items);
            orderList.Add(order1);
            service.AddOrder(customer, items);
            service.DeleteOrder(1);
            CollectionAssert.Equals(orderList, service.orderList);
        }

        [TestMethod()]
        public void SearchOrderNumTest()
        {
            service.SearchOrderNum(1);
        }

        [TestMethod()]
        public void SearchItemNameTest()
        {
            service.SearchItemName("鞋子");
        }

        [TestMethod()]
        public void SearchCustomerTest()
        {
            service.SearchCustomer("Lagueen");
            Assert.Equals(customer.customerName, "Lagueen");
        }


        [TestMethod()]
        public void SetOrderNumTest()
        {
            service.SetOrderNum(1, 100);
            Assert.AreEqual(service.orderList[0].orderNo, 100);
        }
    }
}