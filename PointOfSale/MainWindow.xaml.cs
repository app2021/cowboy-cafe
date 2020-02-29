using CowboyCafe.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var data = new Order();
            DataContext = data;

            CancelOrderButton.Click += OnCancelOrderButtonClicked;
            CompleteOrderButton.Click += OnCompleteOrderButtonClicked;
        }

        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

    }
}
