/*
 * Author: Nickolas Appino
 * Class: OrderControl.xaml.cs
 * Purpose: Interaction logic  
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            var data = new Order();
            this.DataContext = data;

            CancelOrderButton.Click += OnCancelOrderButtonClicked;
            CompleteOrderButton.Click += OnCompleteOrderButtonClicked;
            ItemSelectionButton.Click += OnItemSelectionButtonClicked;

        }

        /// <summary>
        /// To swap the screen
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        /// <summary>
        /// To swap the screen
        /// </summary>
        /// <param name="element"></param>
        public void SwapOrderSum(UIElement element)
        {
            OutsideBorder.Child = element;
        }

        /// <summary>
        /// When Item slection button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {

            Container.Child = new MenuItemSelectionControl();

        }

        /// <summary>
        /// When Cancel Order button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
            Container.Child = new MenuItemSelectionControl();

        }

        /// <summary>
        /// When Complete Order button is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            OutsideBorder.Child = new TransactionControl();

        }


        


    }
}
