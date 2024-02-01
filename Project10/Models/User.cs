using System;

namespace Project10.Models;

public class User
{
    public int UserID { get; set; }
    public int Role { get; set; }
    public string UserName { get; set; } = String.Empty;
    public string Login { get; set; } = String.Empty;
    public string Password { get; set; } =String.Empty;
}