using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2_10._05._2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Power { get; set; }
    public int Year { get; set; }
    public string Helm { get; set; }
    public string Drive { get; set; }
    public int Cost { get; set; }
    public int Distante { get; set; }
    public string Type { get; set; }
    public string Client { get; set; }
    public string Customer { get; set; }
    public int Price { get; set; }
    public bool StartDate { get; set; }



}
