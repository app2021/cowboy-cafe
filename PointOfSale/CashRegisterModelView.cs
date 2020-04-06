/*
 * Author: Nickolas Appino
 * Class: CashRegisterModelView.cs
 * Purpose: The Cash Register Model View
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;
using CowboyCafe.Extensions;
using CowboyCafe.Data;
using System.Windows;
using System.Windows.Controls;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for  cash regisiter model view
    /// </summary>
    public class CashRegisterModelView: INotifyPropertyChanged
    {
        /// <summary>
        /// Event that notifies when properties change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The Model class for this ModelView
        /// </summary> 
        CashDrawer drawer = Register.CashDrawer;

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        /// <summary>
        /// When the complete button is pressed
        /// </summary>
        public void complete()
        {

            Pennies = Pennies + EnterPennies;
            Dimes = Dimes + EnterDimes;
            Nickels = Nickels + EnterNickels;
            Quarters = Quarters + EnterQuarters;
            HalfDollars = HalfDollars + EnterHalfDollars;
            Dollars = Dollars + EnterDollars;

            Ones = Ones + EnterOnes;
            Twos = Twos + EnterTwos;
            Fives = Fives + EnterFives;
            Tens = Tens + EnterTens;
            Twentys = Twentys + EnterTwentys;
            Fiftys = Fiftys + EnterFiftys;
            Hundreds = Hundreds + EnterHundreds;



            MessageBox.Show(ReturnChange());


            string reciept = Register.Receipt;

            reciept += "\n\nTotal Paid: " + EnterTotal.ToString("C2")
                       +  "\nTotal Change: " + Change.ToString("C02")
                       + "\n\n" + DateTime.Now.ToString() +"\n\n";


            ReceiptPrinter rp = Register.ReceiptPrinter;
            rp.Print(reciept);
        }

        /// <summary>
        /// Whether or not the complete button should be enabled
        /// </summary>
        public bool CompleteButtonEnabled
        {
            get
            {
                if (EnterTotal >= Register.OrderTotal)
                {
                    return true;
                }
                return false;

            }
        } 

        /// <summary>
        /// the amount of change due a customer
        /// </summary>
        public double Change
        {
            get
            {
                return EnterTotal - Register.OrderTotal;
            }
        }

        
        /// <summary>
        /// Calculates the amount of change due the customer and subtracts it from the cash
        /// register
        /// </summary>
        /// <returns>A string of the bills and coins to return</returns>
        public string ReturnChange()
        {
            double ReturnChange = Change;
            
            
            int HundredsChange = (int)( ReturnChange / 100); // how much to return
                if (HundredsChange >= Hundreds)                // if amount to return is more than what there is
                {
                    ReturnChange = ReturnChange - (Hundreds * 100);  // remove all there is
                    HundredsChange = Hundreds;
                    Hundreds = 0;


            }
            else
                {
                    ReturnChange = ReturnChange - (HundredsChange * 100);
                    Hundreds = Hundreds - HundredsChange;
                }
            


            int FiftiesChange = (int)(ReturnChange / 50);
            if (FiftiesChange > 0)
            {
                if (FiftiesChange >= Fiftys)
                {
                    ReturnChange = ReturnChange - (Fiftys * 50);
                    FiftiesChange = Fiftys;
                    Fiftys = 0;
                }
                else
                {
                    ReturnChange = ReturnChange - (FiftiesChange * 50);
                    Fiftys = Fiftys - FiftiesChange;
                }
            }


            int TwentiesChange = (int)(ReturnChange / 20);
            if (TwentiesChange > 0)
            {
                if (TwentiesChange >= Twentys)
                {
                    ReturnChange = ReturnChange - (Twentys * 20);
                    TwentiesChange = Twentys;
                    Twentys = 0;

                }
                else
                {
                    ReturnChange = ReturnChange - (TwentiesChange * 20);
                    Twentys = Twentys - TwentiesChange;
                }
            }

            int TensChange = (int)(ReturnChange / 10);
            if (TensChange > 0)
            {
                if (TensChange >= Tens)
                {
                    ReturnChange = ReturnChange - (Tens * 10);
                    TensChange = Tens;
                    Tens = 0;
                }
                else
                {
                    ReturnChange = ReturnChange - (TensChange * 10);
                    Tens = Tens - TensChange;
                }
            }

            int FivesChange = (int)(ReturnChange / 5);
            if(FivesChange >= Fives)
            {
                ReturnChange = ReturnChange - (Fives * 5);
                FivesChange = Fives;
                Fives = 0;

            }
            else
            {
                ReturnChange = ReturnChange - (FivesChange * 5);
                Fives = Fives - FivesChange;
            }


            int OnesChange = (int)(ReturnChange / 1);
            if(OnesChange >= Ones)
            {
                ReturnChange = ReturnChange - (Ones * 1);
                OnesChange = Ones;
                Ones = 0;

            }
            else
            {
                ReturnChange = ReturnChange - (OnesChange * 1);
                Ones = Ones - OnesChange;

            }

            int HalfDollarsChange = (int) (ReturnChange / .5);
            if(HalfDollarsChange >= HalfDollars)
            {
                ReturnChange = ReturnChange - (HalfDollars * .5);
                HalfDollarsChange = HalfDollars;
                HalfDollars = 0;
            }
            else
            {
                ReturnChange = ReturnChange - (HalfDollarsChange * .5);
                HalfDollars = HalfDollars - HalfDollarsChange;

            }

            int QuartersChange = (int) (ReturnChange / (.25));
            if(QuartersChange >= Quarters)
            {
                ReturnChange = ReturnChange - (Quarters * .25);
                QuartersChange = Quarters;

                Quarters = 0;
            }
            else
            {
                ReturnChange = ReturnChange - (QuartersChange * .25);
                Quarters = Quarters - QuartersChange;

            }

            int DimesChange = (int) (ReturnChange / .1);
            if(DimesChange >= Dimes)
            {
                ReturnChange = ReturnChange - (Dimes * .1);
                DimesChange = Dimes;
                Dimes = 0;

            }
            else
            {
                ReturnChange = ReturnChange - (DimesChange * .1);
                Dimes = Dimes - DimesChange;

            }

            int NickelsChange = (int)(ReturnChange / .05);
            if(NickelsChange >= Nickels)
            {
                ReturnChange = ReturnChange - (Nickels * .05);
                NickelsChange = Nickels;
                Nickels = 0;

            }
            else
            {
                ReturnChange = ReturnChange - (NickelsChange * .05);
                Nickels = Nickels - NickelsChange;

            }

            int PenniesChange = (int)(ReturnChange / .01);
            if(PenniesChange >= Pennies)
            {
                ReturnChange = ReturnChange - (Pennies * .01);
                PenniesChange = Pennies;
                Pennies = 0;

            }
            else
            {
                ReturnChange = ReturnChange - (PenniesChange * .01);
                Pennies = Pennies - PenniesChange;

            }

            if (ReturnChange >= .005)
            {
                PenniesChange++;
            }

            string r = "Change due: \n\n";

            if(HundredsChange > 0)
            {
                r += "Hundreds: " + HundredsChange;
            }

            if(FiftiesChange > 0)
            {
                r += "\nFifties: " + FiftiesChange;
            }

            if(TwentiesChange > 0)
            {
                r += "\nTwenties: " + TwentiesChange;
            }

            if(TensChange > 0)
            {
                r += "\nTens: " + TensChange;
            }

            if(FivesChange > 0)
            {
                r += "\nFives: " + FivesChange;
            }

            if(OnesChange > 0)
            {
                r += "\nOnes: " + OnesChange;
            }

            if(HalfDollarsChange > 0)
            {
                r += "\nHalf Dollars: " + HalfDollarsChange;
            }

            if(QuartersChange > 0)
            {
                r += "\nQuarters: " + QuartersChange;
            }

            if(DimesChange > 0)
            {
                r += "\nDimes: " + DimesChange;
            }

            if(NickelsChange > 0)
            {
                r += "\nNickels: " + NickelsChange;
            }

            if(PenniesChange > 0)
            {
                r += "\nPennies: " + PenniesChange;
            }

            r += "\n\n Total Change: " + Change.ToString("C2");

            return r;
        }

        /// <summary>
        /// For error checking. Displays what's in the Cashdrawer.
        /// </summary>
        /// <returns>String of what's in the Cash Drawer</returns>
        public string WhatsIn()
        {
            string r = "\n\nHundreds: " + Hundreds
            + "\nFifties: " + Fiftys
            + "\nTwenties: " + Twentys
            + "\nTens: " + Tens
            + "\nFives: " + Fives
            + "\nOnes: " + Ones
            + "\nDollars: " + Dollars
            + "\nHalf Dollars: " + HalfDollars
            + "\nQuarters: " + Quarters
            + "\nDimes: " + Dimes
            + "\nNickels: " + Nickels
            + "\nPennies: " + Pennies
            ;

            return r;
        }

        /// <summary>
        /// The total of the order
        /// </summary>
        public double Total
        {
            get
            {
                return Register.OrderTotal;
            }

        }

        /// <summary>
        /// The order number of the order
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                return Register.OrderNumber;
            }
        }



        /// <summary>
        /// Amount that the customer provides
        /// </summary>
        private int enterPennies;
        public int EnterPennies
        {
            get
            {

                return enterPennies;
            }
            set
            {
                if ((value + enterPennies) < 0) return;
                enterPennies = value;
                InvokePropertyChanged("EnterPennies");
                InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");

            }
        }

        /// <summary>
        /// Amount that the customer provides 
        /// </summary>
        private int enterDimes;
        public int EnterDimes
        {
            get
            {
                return enterDimes;
            }
            set
            {
                if ((value + enterDimes) < 0) return;
                enterDimes = value;
                InvokePropertyChanged("EnterDimes");
                 InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");


            }
        }

        /// <summary>
        /// Amount that the customer provides
        /// </summary>
        private int enterNickels;
        public int EnterNickels
        {
            get
            {
                return enterNickels;
            }
            set
            {
                if ((value + enterNickels) < 0) return;
                enterNickels = value;
                  InvokePropertyChanged("EnterNickels");
                  InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");

            }
        }

        /// <summary>
        /// Amount that the customer provides
        /// </summary>
        private int enterQuarters;
        public int EnterQuarters
        {
            get
            {
                return enterQuarters;
            }
            set
            {
                if ((value + enterQuarters) < 0) return;
                enterQuarters = value;
                  InvokePropertyChanged("EnterQuarters");
                  InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");

            }
        }

        /// <summary>
        /// Amount that the customer provides
        /// </summary>
        private int enterHalfDollars;
        public int EnterHalfDollars
        {
            get
            {
                return enterHalfDollars;
            }
            set
            {
                if ((value + enterHalfDollars) < 0) return;
                enterHalfDollars = value;
                    InvokePropertyChanged("EnterHalfDollars");
                    InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");

            }
        }

        /// <summary>
        /// Amount that the customer provides
        /// </summary>
        private int enterDollars;
        public int EnterDollars
        {
            get
            {
                return enterDollars;
            }
            set
            {
                if ((value + enterDollars) < 0) return;
                enterDollars = value;
                    InvokePropertyChanged("EnterDollars");
                   InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");

            }
        }

        private int enterOnes;
        public int EnterOnes
        {
            get
            {
                return enterOnes;
            }
            set
            {
                if ((value + enterOnes) < 0) return;
                enterOnes = value;
                InvokePropertyChanged("EnterOnes");
                InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");

            }
        }

        /// <summary>
        /// Amount that the customer provides
        /// </summary>
        private int enterTwos;
        public int EnterTwos
        {
            get
            {
                return enterTwos;
            }
            set
            {
                if ((value + enterTwos) < 0) return;
                enterTwos = value;
                InvokePropertyChanged("EnterTwos");
                InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");
            }
        }

        /// <summary>
        /// Amount that the customer provides
        /// </summary>
        private int enterFives;
        public int EnterFives
        {
            get
            {
                return enterFives;
            }
            set
            {
                if ((value + enterFives) < 0) return;
                enterFives = value;
                InvokePropertyChanged("EnterFives");
                InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");

            }
        }

        /// <summary>
        /// Amount that the customer provides
        /// </summary>
        private int enterTens;
        public int EnterTens
        {
            get
            {
                return enterTens;
            }
            set
            {
                if ((value + enterTens) < 0) return;
                enterTens = value;
                InvokePropertyChanged("EnterTens");
                InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");

            }
        }

        /// <summary>
        /// Amount that the customer provides
        /// </summary>
        private int enterTwentys;
        public int EnterTwentys
        {
            get
            {
                return enterTwentys;
            }
            set
            {
                if ((value + enterTwentys) < 0) return;
                enterTwentys = value;
                InvokePropertyChanged("EnterTwentys");
                InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");

            }
        }

        /// <summary>
        /// Amount that the customer provides
        /// </summary>
        private int enterFiftys;
        public int EnterFiftys
        {
            get
            {
                return enterFiftys;
            }
            set
            {
                if ((value + enterFiftys) < 0) return;
                enterFiftys = value;
                InvokePropertyChanged("EnterFiftys");
                InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");

            }
        }

        /// <summary>
        /// Amount that the customer provides
        /// </summary>
        private int enterHundreds;
        public int EnterHundreds
        {
            get
            {
                return enterHundreds;
            }
            set
            {
                if ((value + enterHundreds) < 0) return;
                enterHundreds = value;
                InvokePropertyChanged("EnterHundreds");
                InvokePropertyChanged("EnterTotal");
                InvokePropertyChanged("CompleteButtonEnabled");

            }
        }

        /// <summary>
        /// The total amount that the customer provides
        /// </summary>
        private double enterTotal;
        public double EnterTotal
        {
            get
            {
                enterTotal = EnterPennies * .01 + EnterDimes * .1 + EnterNickels * .05 + EnterQuarters * .25 + EnterHalfDollars * .5 + EnterDollars
                    + EnterOnes + EnterTwos * 2 + EnterFives * 5 + EnterTens * 10 + EnterTwentys * 20 + EnterFiftys * 50 + EnterHundreds * 100;
                return enterTotal;
            }

        }




        /// <summary>
        /// Invokes the PropertyChanged event for denomination properties
        /// and the TotalValue
        /// </summary>
        /// <param name="denomination">The property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }






        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                int quantity = value - drawer.Pennies;
                if (quantity > 0) drawer.AddCoin(Coins.Penny, quantity);
                else drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Gets or sets the number of dimes in the cash register
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0) return;
                int quantity = value - drawer.Dimes;
                if (quantity > 0) drawer.AddCoin(Coins.Dime, quantity);
                else drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Gets or sets the number of nickels in the cash register
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0) return;
                int quantity = value - drawer.Nickels;
                if (quantity > 0) drawer.AddCoin(Coins.Nickel, quantity);
                else drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Gets or sets the number of quarter in the cash register
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0) return;
                int quantity = value - drawer.Quarters;
                if (quantity > 0) drawer.AddCoin(Coins.Quarter, quantity);
                else drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");
            }
        }

        /// <summary>
        /// Gets or sets the number of halfdollars in the cash register
        /// </summary>
        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                int quantity = value - drawer.HalfDollars;
                if (quantity > 0) drawer.AddCoin(Coins.HalfDollar, quantity);
                else drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollars");
            }
        }

        /// <summary>
        /// Gets or sets the number of dollars in the cash register
        /// </summary>
        public int Dollars
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value || value < 0) return;
                int quantity = value - drawer.Dollars;
                if (quantity > 0) drawer.AddCoin(Coins.Dollar, quantity);
                else drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollars");
            }
        }
        
        /// <summary>
        /// Gets or sets the number of ones in the cash register
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;
            set
            {
                if (drawer.Ones == value || value < 0) return;
                int quantity = drawer.Ones - value;
                if (quantity > 0) drawer.RemoveBill(Bills.One, quantity);
                else drawer.AddBill(Bills.One, -quantity);
                InvokePropertyChanged("Ones");
            }
        }


        /// <summary>
        /// Gets or sets the number of twos in the cash register
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;
            set
            {
                if (drawer.Twos == value || value < 0) return;
                int quantity = drawer.Twos - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Two, quantity);
                else drawer.AddBill(Bills.Two, -quantity);
                InvokePropertyChanged("Twos");
            }
        }


        /// <summary>
        /// Gets or sets the number of fives in the cash register
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;
            set
            {
                if (drawer.Fives == value || value < 0) return;
                int quantity = drawer.Fives - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Five, quantity);
                else drawer.AddBill(Bills.Five, -quantity);
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Gets or sets the number of tens in the cash register
        /// </summary>
        public int Tens
        {
            get => drawer.Tens;
            set
            {
                if (drawer.Tens == value || value < 0) return;
                int quantity = drawer.Tens - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Ten, quantity);
                else drawer.AddBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Tens");
            }
        }


        /// <summary>
        /// Gets or sets the number of twentys in the cash register
        /// </summary>
        public int Twentys
        {
            get => drawer.Twenties;
            set
            {
                if (drawer.Twenties == value || value < 0) return;
                int quantity = drawer.Twenties - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Twenty, quantity);
                else drawer.AddBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twentys");
            }
        }


        /// <summary>
        /// Gets or sets the number of fiftys in the cash register
        /// </summary>
        public int Fiftys
        {
            get => drawer.Fifties;
            set
            {
                if (drawer.Fifties == value || value < 0) return;
                int quantity = drawer.Fifties - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Fifty, quantity);
                else drawer.AddBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fiftys");
            }
        }



        /// <summary>
        /// Gets or sets the number of hundreds int he cash register
        /// </summary>
        public int Hundreds
        {
            get => drawer.Hundreds;
            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                int quantity = drawer.Hundreds - value;
                if (quantity > 0) drawer.RemoveBill(Bills.Hundred, quantity);
                else drawer.AddBill(Bills.Hundred, -quantity);
                InvokePropertyChanged("Hundreds");
            }
        }

    }
}

