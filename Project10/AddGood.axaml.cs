using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Project10.Models;

namespace Project10;

public partial class AddGood : Window
{
    public AddGood(Good selectedGood)
    {
        InitializeComponent();
    }
}