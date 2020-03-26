/*
 * Author: Nickolas Appino
 * Class: OrderSummaryControl.xaml.cs
 * Purpose: Interaction logic for OrderSummaryControl.xaml
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
            
        }

        public void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            //  public void Remove(IOrderItem item) {

            var orderControl = this.FindAncestor<OrderControl>();
            if (orderControl == null) return;

            if (sender is Button button)
                {

                }

        }


        //OrderControl to switch screens, The item that is being customized(the same instance)
        //The screen that we switch to
        void itemSelected(object sender, SelectionChangedEventArgs args)
        {

            var orderControl = this.FindAncestor<OrderControl>();
            if (orderControl == null) return;

            foreach(object o in args.AddedItems)
            {
                if(o is AngryChicken)
                {
                    var screen = new CustomizeAngryChicken();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);

                }
                else if(o is BakedBeans)
                {
                    var screen = new CustomizeSide();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
                else if (o is ChiliCheeseFries)
                {
                    var screen = new CustomizeChiliCheeseFries();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
                else if (o is CornDodgers)
                {
                    var screen = new CustomizeSide();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
                else if (o is CowboyCoffee)
                {
                    var screen = new CustomizeCowboyCoffee();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
                else if (o is CowpokeChili)
                {
                    var screen = new CustomizeCowpokeChili();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
                else if (o is DakotaDoubleBurger)
                {
                    var screen = new CustomizeDakotaDoubleBurger();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
            }

        }

    }
}
