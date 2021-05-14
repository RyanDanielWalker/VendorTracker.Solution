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
      Vendor.ClearAll();
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
      DateTime result = new DateTime(06 / 14 / 2021);
      Assert.AreEqual(date, result);
    }

  }
}