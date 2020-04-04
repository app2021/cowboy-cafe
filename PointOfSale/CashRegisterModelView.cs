﻿using System;
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

        public void complete()
        {
            WhatsIn();

            Pennies = Pennies + EnterPennies;
            Dimes = Dimes + EnterDimes;
            Nickels = Nickels + EnterNickels;
            Quarters = Quarters + EnterQuarters;
            HalfDollars = HalfDollars + EnterHalfDollars;
            Dollars = Dollars + EnterDollars;

            WhatsIn();

            MessageBox.Show(ReturnChange());

            WhatsIn();
        }

        private bool completeButtonEnabled;
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

        public double Change
        {
            get
            {
                return EnterTotal - Register.OrderTotal;
            }
        }

        public string ReturnChange()
        {
            double ReturnChange = Change;
            
            
            int HundredsChange = (int) ReturnChange / 100;
            if (HundredsChange > Hundreds)
            {
                ReturnChange = ReturnChange - (Hundreds * 100);
                Hundreds = 0;
            }
            else
            {
                ReturnChange = ReturnChange - (HundredsChange * 100);
                Hundreds = Hundreds -HundredsChange;
            }


            int FiftiesChange = (int)ReturnChange / 50;
            if (FiftiesChange > Fiftys)
            {
                ReturnChange = ReturnChange - (Fiftys * 50);
                Fiftys = 0;
            }
            else
            {
                ReturnChange = ReturnChange - (FiftiesChange * 50);
                Fiftys = Fiftys - FiftiesChange;
            }


            int TwentiesChange = (int)ReturnChange / 20;
            if (TwentiesChange > Twentys)
            {
                ReturnChange = ReturnChange - (Twentys * 20);
                Twentys = 0;

            }
            else
            {
                ReturnChange = ReturnChange - (TwentiesChange * 20);
                Twentys = Twentys - TwentiesChange;
            }

            int TensChange = (int)ReturnChange / 10;
            if(TensChange > Tens)
            {
                ReturnChange = ReturnChange - (Tens * 10);
                Tens = 0;
            }
            else
            {
                ReturnChange = ReturnChange - (TensChange * 10);
                Tens = Tens - TensChange;
            }

            int FivesChange = (int)ReturnChange / 5;
            if(FivesChange > Fives)
            {
                ReturnChange = ReturnChange - (Fives * 5);
                Fives = 0;

            }
            else
            {
                ReturnChange = ReturnChange - (FivesChange * 5);
                Fives = FivesChange - Fives;
            }


            int OnesChange = (int)ReturnChange / 1;
            if(OnesChange > Ones)
            {
                ReturnChange = ReturnChange - (Ones * 1);
                Ones = 0;

            }
            else
            {
                ReturnChange = ReturnChange - (OnesChange * 1);
                Ones = Ones - OnesChange;

            }

            int HalfDollarsChange = (int) (ReturnChange / .5);
            if(HalfDollarsChange > HalfDollars)
            {
                ReturnChange = ReturnChange - (HalfDollars * .5);
                HalfDollars = 0;
            }
            else
            {
                ReturnChange = ReturnChange - (HalfDollarsChange * .5);
                HalfDollars = HalfDollars - HalfDollarsChange;

            }

            int QuartersChange = (int) (ReturnChange / (.25));
            if(QuartersChange > Quarters)
            {
                ReturnChange = ReturnChange - (Quarters * .25);
                Quarters = 0;
            }
            else
            {
                ReturnChange = ReturnChange - (QuartersChange * .25);
                Quarters = Quarters - QuartersChange;

            }

            int DimesChange = (int) (ReturnChange / .1);
            if(DimesChange > Dimes)
            {
                ReturnChange = ReturnChange - (Dimes * .1);
                Dimes = 0;

            }
            else
            {
                ReturnChange = ReturnChange - (DimesChange * .1);
                Dimes = Dimes - DimesChange;

            }

            int NickelsChange = (int)(ReturnChange / .05);
            if(NickelsChange > Nickels)
            {
                ReturnChange = ReturnChange - (Nickels * .05);
                Nickels = 0;

            }
            else
            {
                ReturnChange = ReturnChange - (NickelsChange * .05);
                Nickels = Nickels - NickelsChange;

            }

            int PenniesChange = (int)(ReturnChange / .01);
            if(PenniesChange > Pennies)
            {
                ReturnChange = ReturnChange - (Pennies * .01);
                Pennies = 0;

            }
            else
            {
                ReturnChange = ReturnChange - (PenniesChange * .01);
                Pennies = Pennies - PenniesChange;

            }


            string r = "Hundreds: " + HundredsChange.ToString()
                        + "\nFifties: " + FiftiesChange.ToString()
                        + "\nTwenties: " + TwentiesChange.ToString()
                        + "\nTens: " + TensChange.ToString()
                        + "\nFives: " + FivesChange.ToString()
                        + "\nOnes: " + OnesChange.ToString()
                        + "\nHalf Dollars: " + HalfDollarsChange.ToString()
                        + "\nQuarters: " + QuartersChange
                        + "\nDimes: " + DimesChange
                        + "\nNickels: " + NickelsChange
                        + "\nPennies: " + PenniesChange
                        + "\n\n Total Change:" + Change
                        ;

            return r;
        }

        public void WhatsIn()
        {
            string r = "Hundreds: " + Hundreds
            + "\nFifties: " + Fiftys
            + "\nTwenties: " + Twentys
            + "\nTens: " + Tens
            + "\nFives: " + Fives
            + "\nOnes: " + Ones
            + "\nHalf Dollars: " + HalfDollars
            + "\nQuarters: " + Quarters
            + "\nDimes: " + Dimes
            + "\nNickels: " + Nickels
            + "\nPennies: " + Pennies
            ;

            MessageBox.Show(r);
        }


        public double Total
        {
            get
            {
                return Register.OrderTotal;
            }

        }

        public uint OrderNumber
        {
            get
            {
                return Register.OrderNumber;
            }
        }




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

        private double enterTotal;
        public double EnterTotal
        {
            get
            {
                enterTotal = EnterPennies * .01 + EnterDimes * .1 + EnterNickels * .05 + EnterQuarters * .25 + EnterHalfDollars * .5 + EnterDollars;
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

