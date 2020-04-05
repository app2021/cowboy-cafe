/*
 * Author: Nickolas Appino
 * Class: Register.cs
 * Purpose: Stores global variables
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using CashRegister;

namespace PointOfSale
{
    public static class Register
    {

        /// <summary>
        /// The Cash Drawer
        /// </summary>
        public static CashDrawer CashDrawer = new CashDrawer();

        /// <summary>
        /// The Receipt Printer
        /// </summary>
        public static ReceiptPrinter ReceiptPrinter = new ReceiptPrinter();

        /// <summary>
        /// The Order's Total
        /// </summary>
        public static double OrderTotal { get; set; }

        /// <summary>
        /// The Order Number
        /// </summary>
        public static uint OrderNumber { get; set; }

        /// <summary>
        /// The Receipt for the order
        /// </summary>
        public static string Receipt { get; set; }



    }
}
