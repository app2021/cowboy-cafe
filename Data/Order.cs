/*
 * Author: Nickolas Appino
 * Class: Order.cs
 * Purpose: A class representing an order
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing an order
    /// </summary>

    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// the last order number used
        /// </summary>
        private static uint lastOrderNumber = 0;

        /// <summary>
        /// Hold all of the items ordered 
        /// </summary>
        public List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// provides an array of all the items ordered
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();


        /// <summary>
        /// The subtotal of the order
        /// </summary>
        public double Subtotal { get; private set; }


        /// <summary>
        /// The current order's order number
        /// </summary>
        public uint OrderNumber {
            get
            {
                return lastOrderNumber;
            }
              }


        public void UpdateSubtotal()
        {
            double s = 0;

            foreach(IOrderItem item in items)
            {
                s += item.Price;
            }

            Subtotal = s;
        }

        /// <summary>
        /// method to add an item to an order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item) {

            if (item is INotifyPropertyChanged notifier) {
                notifier.PropertyChanged += OnItemPropertyChanged;
            }

            items.Add(item);
            Subtotal += item.Price;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        /// <summary>
        /// method to remove an item from an order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item) {

            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChanged;

            }

            items.Remove(item);
            Subtotal -= item.Price;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        /// <summary>
        /// constructor that creates a new order number
        /// </summary>
        public Order()
        {
            lastOrderNumber++;

        }

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            UpdateSubtotal();


            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

    }
}
