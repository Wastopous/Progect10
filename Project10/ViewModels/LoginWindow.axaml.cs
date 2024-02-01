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
    }

    private void LoginButton_OnClick(object? sender, RoutedEventArgs e)
    {

        using (MySqlConnection connection = new MySqlConnection())
        {
            connection.Open();
            
            string query = "SELECT COUNT(*) FROM user WHERE login = @login and password = @password";
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@login", LoginTextBox.Text);
                cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }
                else
                {
                    WrongPanel.IsVisible = true;
                }

            }
        }
    }
}