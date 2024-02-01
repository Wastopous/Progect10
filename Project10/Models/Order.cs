using System;

namespace Project10.Models;

public class Order
{
    public int OrderID { get; set; }
    public DateTimeOffset OrderDate { get; set; }
    public DateTimeOffset DeliveryDate { get; set; }
    public int User { get; set; }
    public int Status { get; set; }
    public int Point { get; set; }
    public int Good { get; set; }
}