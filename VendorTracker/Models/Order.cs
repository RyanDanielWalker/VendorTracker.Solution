using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string orderTitle, string orderDescription)
    {
      Title = orderTitle;
      Description = orderDescription;
      // Price = orderPrice;
      // Date = orderDate;
      // _instances.Add(this);
      // Id = _instances.Count;
    }

  }
}