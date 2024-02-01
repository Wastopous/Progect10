using System;

namespace Project10.Models;

public class Good
{
    public int GoodID { get; set; }
    public string GoodName { get; set; } = String.Empty;
    public string GoodDesc { get; set; } = String.Empty;
    public decimal GoodPrice { get; set; }  
    public int GoodCount { get; set; }
    public int Provider { get; set; }
    public int Producer { get; set; }
    public int Category { get; set; }
}