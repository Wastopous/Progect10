using Avalonia.Controls;
using Avalonia.Input;
using Project10.ViewModels;

namespace Project10;

public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void RegisterLabel_OnTapped(object? sender, TappedEventArgs e)
    {
        RegisterWindow registerWindow = new RegisterWindow();
        registerWindow.Show();
    }
}