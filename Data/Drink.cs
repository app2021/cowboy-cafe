/*
 * Author: Nickolas Appino
 * Class: Drink.cs
 * Purpose: An abstract class representing a drink
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An abstract class representing a drink
    /// </summary>
    public abstract class Drink: IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private Size size;

        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                /*NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Small");
                NotifyOfPropertyChange("Medium");
                NotifyOfPropertyChange("Large");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Items");
                NotifyOfPropertyChange("Subtotal");*/

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Small"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Medium"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Large"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

            }

        }

        public bool Small
        {
            get
            {
                if (Size == Size.Small)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    Size = Size.Small;

                }

            }
        }


        public bool Medium
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    Size = Size.Medium;

                }

            }
        }

        public bool Large
        {
            get
            {
                if (Size == Size.Large)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (value == true)
                {
                    Size = Size.Large;

                }

            }
        }

        /// <summary>
        /// The price of the drink
        /// </summary>
        //public virtual double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for the drink
        /// </summary>
        //public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// If the drink should have ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;


        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
