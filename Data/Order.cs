using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private static uint lastOrderNumber = 0;

        public List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => items.ToArray();


        public List<double> itemsPrice = new List<double>();
        public IEnumerable<double> ItemsPrice => itemsPrice.ToArray();



        public double Subtotal { get; private set; }



        public uint OrderNumber {
            get
            {
                return lastOrderNumber;
            }
              }

        public void Add(IOrderItem item) {

            items.Add(item);
            itemsPrice.Add(item.Price);

            Subtotal += item.Price;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemsPrice"));




        }

        public void Remove(IOrderItem item) {

            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            Subtotal -= item.Price;
        }

        public Order()
        {
            lastOrderNumber++;

        }

    }
}
