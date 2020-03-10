/*
 * Author: Nickolas Appino
 * Class: Entree.cs
 * Purpose: An abstract class for the Entree menu items
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{


    /// <summary>
    /// An abstract class for the Entrees 
    /// </summary>
    public abstract class Entree: IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// To implement the INotifyPropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        //public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the Special Instructions of the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }


        /// <summary>
        /// Fancy method to handle the Property Change Event Args
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }


    }
}
