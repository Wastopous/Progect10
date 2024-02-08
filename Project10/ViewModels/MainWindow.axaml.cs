using System.Collections.ObjectModel;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using DynamicData;
using MySql.Data.MySqlClient;
using Project10.Models;

namespace Project10.ViewModels;

public partial class MainWindow : Window
{


    public MainWindow()
    {
        InitializeComponent();
        
    }

    private DataBase _dataBase = new DataBase();
    private ObservableCollection<Good> _goods;
    
    private string s = "select goodid, goodname, gooddesc, goodcount, goodprice, providername, providername, category product" +
                       " join producer p on p.producer_id = product.producer" +
                       " join provider pp on product.provider = s.provider" +
                       " join category pc on product.category = pc.categoryid";

    private void QuitButton_OnClick(object? sender, RoutedEventArgs e)
    {
        this.Close();
        LoginWindow loginWindow = new LoginWindow();
        Show(s);
    }

    public void Show(string _s)
    {
        _dataBase.openConnection();
        MySqlCommand c = new MySqlCommand(_s, _dataBase.GetConnection());
        MySqlDataReader r = c.ExecuteReader();
        while (r.Read() && r.HasRows)
        {
            var curGood = new Good()
            {
            GoodID = r.GetInt32("GoodID"),
            GoodName = r.GetString("GoodName"),
            GoodDesc = r.GetString("GoodDesc"),
            GoodCount = r.GetInt32("GoodCount"),
            GoodPrice = r.GetDecimal("GoodPrice"),
            Provider = r.GetString("ProviderName"),
            Producer = r.GetString("ProducerName"),
            Category = r.GetString("CategoryName")
            };
            _goods.Add(curGood);
        }
        _dataBase.CloseConnection();
        GoodListBox.ItemsSource = _goods;
    }
    


    private void Search_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        ObservableCollection<Good> search =
            new ObservableCollection<Good>(_goods.Where(x =>
                x.GoodName.ToLower().Contains(Search.Text.ToLower())));
        GoodListBox.ItemsSource = search;
    }

    private void AddButton_OnClick(object? sender, RoutedEventArgs e)
    {
        Good selectedGood = GoodListBox.SelectedItem as Good;
        if (selectedGood != null)
        {
            Panel.Children.Clear();
            AddGood addProductPage = new AddGood(selectedGood);
            Panel.Children.Add(addProductPage);
        }
    }   
}