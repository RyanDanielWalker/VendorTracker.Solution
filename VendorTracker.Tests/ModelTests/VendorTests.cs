using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstancesOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      string description = "Test description";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string description = "Test description";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsVendorDescription_String()
    {
      string name = "Test Vendor";
      string description = "Test description";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "Test Vendor01";
      string description01 = "Test description01";
      string name02 = "Test Vendor02";
      string description02 = "Test description02";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "Test Vendor01";
      string description01 = "Test description01";
      string name02 = "Test Vendor02";
      string description02 = "Test description02";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string title = "Bread";
      string orderDescription = "bread";
      int price = 142;
      DateTime date = new DateTime(2021, 05, 14);
      Order newOrder = new Order(title, orderDescription, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Test Vendor";
      string vendorDescription = "Test description";
      Vendor newVendor = new Vendor(name, vendorDescription);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }

  }
}
