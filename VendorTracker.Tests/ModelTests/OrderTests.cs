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
      Order newOrder = new Order("test", "description", 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Bread";
      string description = "bread";
      int price = 142;
      Order newOrder = new Order(title, description, price);
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string title = "Bread";
      string description = "bread";
      int price = 142;
      Order newOrder = new Order(title, description, price);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetPrice_ReturnsOrderPrice_Int()
    {
      string title = "Bread";
      string description = "bread";
      int price = 142;
      Order newOrder = new Order(title, description, price);
      int result = 90;
      Assert.AreEqual(price, result);
    }

  }
}