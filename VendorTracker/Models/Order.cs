using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Date { get; set; }
    private static List<Order> _instances = new List<Order> { };

    // public Order()
    // {

    // }
  }
}