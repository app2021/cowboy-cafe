using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order: INotifyPropertyChanged
    {

        private static uint lastOrderNumber = 0;

        public List<IOrderItem> items = new List<IOrderItem>();

        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<IOrderItem> Items => items.ToArray();


        private double subtotal;

        public double Subtotal { 
            
            get
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("subtotal"));
                return subtotal;
            }
                 }

        public uint OrderNumber {
            get
            {
                return lastOrderNumber;
            }
              }

        public void Add(IOrderItem item) {

            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            subtotal += item.Price;

        }

        public void Remove(IOrderItem item) {

            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            subtotal -= item.Price;
        }

        public Order()
        {
            lastOrderNumber++;
        }

    }
}
