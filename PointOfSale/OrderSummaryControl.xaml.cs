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

         void OnRemoveItem(object sender, RoutedEventArgs e)
        {
            
            if (sender is Button)
            {
                Button b = (Button)sender;
                IOrderItem i = (IOrderItem)b.DataContext;
                Order o = (Order)DataContext;
                o.Remove(i);                

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
                else if (o is JerkedSoda)
                {
                    var screen = new CustomizeJerkedSoda();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
                else if (o is PanDeCampo)
                {
                    var screen = new CustomizeSide();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
                else if (o is PecosPulledPork)
                {
                    var screen = new CustomizePecosPulledPork();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
                else if (o is TexasTea)
                {
                    var screen = new CustomizeTexasTea();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
                else if (o is TexasTripleBurger)
                {
                    var screen = new CustomizeTexasTripleBurger();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
                else if (o is TrailBurger)
                {
                    var screen = new CustomizeTrailBurger();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
                else if (o is Water)
                {
                    var screen = new CustomizeWater();
                    screen.DataContext = o;
                    orderControl.SwapScreen(screen);
                }
            }

        }

    }
}
