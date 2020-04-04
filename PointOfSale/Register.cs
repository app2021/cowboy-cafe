using System;
using System.Collections.Generic;
using System.Text;
using CashRegister;

namespace PointOfSale
{
    public static class Register
    {

        public static CashDrawer CashDrawer = new CashDrawer();

        public static ReceiptPrinter ReceiptPrinter = new ReceiptPrinter();



        public static double OrderTotal { get; set; }

        public static uint OrderNumber { get; set; }

        public static string Receipt { get; set; }



    }
}
