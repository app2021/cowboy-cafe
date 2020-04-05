/*
 * Author: Nickolas Appino
 * Class: CashRegisterControl.xaml.cs
 * Purpose: Interaction logic for CashRegisterControl.xaml
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
using CashRegister;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        public CashRegisterControl()
        {
            InitializeComponent();

            Complete.Click += OnCompleteClicked;

        }

        /// <summary>
        /// When complete button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteClicked(object sender, RoutedEventArgs e)
        {


            CashRegisterModelView cr = (CashRegisterModelView)DataContext;
            cr.complete();
            var orderInfo = this.FindAncestor<OrderControl>();
            OrderControl o = new OrderControl();
            orderInfo.SwapOrderSum(o);
        }



    }
    }

