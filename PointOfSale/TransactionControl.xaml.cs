/*
 * Author: Nickolas Appino
 * Class: TransactionControl.xaml.cs
 * Purpose: Interaction logic for TransactionControl.xaml
 * 
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
using CowboyCafe.Extensions;
using CashRegister;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();

            CreditButton.Click += OnCreditButtonClicked;
            CashButton.Click += OnCashButtonClicked;
            CancelButton.Click += OnCancelButtonClicked;
        }

        /// <summary>
        /// When the credit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCreditButtonClicked(object sender, RoutedEventArgs e)
        {
            CardTerminal card = new CardTerminal();
            Order o = (Order)DataContext;
            double total = o.Total;
            ResultCode result = card.ProcessTransaction(total);

            if(result == ResultCode.Success)
            {
                ReceiptPrinter rp = Register.ReceiptPrinter;
                String reciept = ReceiptCreator();
                reciept += "\n\nPaid by Credit Card\n\n";
                reciept += DateTime.Now.ToString() + "\n\n";

                rp.Print(reciept);


                var orderInfo = this.FindAncestor<OrderControl>();
                OrderControl od = new OrderControl();
                orderInfo.SwapOrderSum(od);
            }
            else
            {
                MessageBox.Show(result.ToString());
            }

        }

        /// <summary>
        /// When the Cash button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCashButtonClicked(object sender, RoutedEventArgs e)
        {

            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new DisplayCashRegisterControl();

            Order order = (Order)DataContext;

            Register.OrderTotal = order.Total;
            Register.OrderNumber = order.OrderNumber;
            Register.Receipt = ReceiptCreator();

            orderControl.SwapOrderSum(screen);
             

        }

        /// <summary>
        /// When the cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderInfo = this.FindAncestor<OrderControl>();
            OrderControl o = new OrderControl();
            orderInfo.SwapOrderSum(o);

        }

        /// <summary>
        /// prints receipt template to a string
        /// </summary>
        /// <returns>string of the receipt</returns>
        string ReceiptCreator()
        {

            Order order = (Order)DataContext;

            string r = "\n-------------------";

            r += "\nOrder Number: " + order.OrderNumber + "\n";

            foreach(IOrderItem i in order.items)
            {


                r += "\n" + i.ToString() + " " + i.Price.ToString("C2") + "\n";

                if (i.SpecialInstructions != null)
                {
                    foreach (String l in i.SpecialInstructions)
                    {
                        r += l + "\n";
                    }
                }

            }

            r += "\nSubtotal: " + order.Subtotal.ToString("C2");
            r += "\nTotal: " + order.Total.ToString("C2");

            return r;
        }


    }
}
