using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstancesOfOrder_Order()
    {
      DateTime date = new DateTime(01 / 01 / 2021);
      Order newOrder = new Order("test", "description", 1, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Bread";
      string description = "bread";
      int price = 142;
      DateTime date = new DateTime(2021, 05, 14);
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string title = "Bread";
      string description = "bread";
      int price = 142;
      DateTime date = new DateTime(2021, 05, 14);
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_Int()
    {
      string title = "Bread";
      string description = "bread";
      int price = 142;
      DateTime date = new DateTime(2021, 05, 14);
      Order newOrder = new Order(title, description, price, date);
      int result = newOrder.Price;
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetDate_ReturnsOrderDate_Int()
    {
      string title = "Bread";
      string description = "bread";
      int price = 142;
      DateTime date = new DateTime(2021, 05, 14);
      Order newOrder = new Order(title, description, price, date);
      DateTime result = newOrder.Date;
      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string title1 = "Bread1";
      string title2 = "Bread2";
      string description1 = "bread1";
      string description2 = "bread2";
      int price1 = 142;
      int price2 = 143;
      DateTime date1 = new DateTime(2021, 05, 14);
      DateTime date2 = new DateTime(2021, 05, 14);
      Order newOrder1 = new Order(title1, description1, price1, date1);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "Bread";
      string description = "bread";
      int price = 142;
      DateTime date = new DateTime(2021, 05, 14);
      Order newOrder = new Order(title, description, price, date);
      int result = 32;
      Assert.AreEqual(1, result);
    }


  }
}