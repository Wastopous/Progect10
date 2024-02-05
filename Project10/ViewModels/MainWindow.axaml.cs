using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Project10.ViewModels;

public partial class MainWindow : Window
{


    public MainWindow()
    {
        InitializeComponent();
        
    }



    private void QuitButton_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
        LoginWindow loginWindow = new LoginWindow();
        loginWindow.Show();
    }
}