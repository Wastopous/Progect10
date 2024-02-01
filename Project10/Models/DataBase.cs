using System.Data;
using MySql.Data.MySqlClient;

namespace Project10.Models;

public class DataBase
{
    //private static string _connectionString = "server=10.10.1.24;user=user_01;password=user01pro;database=pro1_16;";
    private MySqlConnection _connection = new MySqlConnection(@"server=localhost;database=project10;port=3306;User=root;password=1234");
    public void openConnection() 
    {
        if (_connection.State == ConnectionState.Closed)
        {
            _connection.Open();
        }
    }
    public void CloseConnection() 
    {
        if (_connection.State == ConnectionState.Open)
        {
            _connection.Close();
        }
    }
    public MySqlConnection GetConnection() 
    {
        return _connection;
    }
}      