using System;
using System.Data;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Project10.ViewModels;
using Project10.Models;
using MySql.Data.MySqlClient;

namespace Project10;

public partial class LoginWindow : Window
{
    private DataBase _dataBase = new DataBase();


    public LoginWindow()
    {

        InitializeComponent();

    }


    private void GuestLabel_OnTapped(object? sender, TappedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }


    private void LoginButton_OnClick(object? sender, RoutedEventArgs e)
    {
  
        string login = LoginTextBox.Text;
        string password = PasswordTextBox.Text;

        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        string sql = "select * from user where login = @login and password = @password";

        MySqlCommand command = new MySqlCommand(sql, _dataBase.GetConnection());
        command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
        adapter.SelectCommand = command;
        adapter.Fill(table);
        if (table.Rows.Count > 0)
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();
        }
    }
}