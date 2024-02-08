using System;

namespace Project10.Models;

public class Good
{
    public int GoodID { get; set; }
    public string GoodName { get; set; } = String.Empty;
    public string GoodDesc { get; set; } = String.Empty;
    public decimal GoodPrice { get; set; }  
    public int GoodCount { get; set; }
    public string Provider { get; set; }
    public string Producer { get; set; }
    public string Category { get; set; }
}