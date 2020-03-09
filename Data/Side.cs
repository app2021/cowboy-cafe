/*
 * Author: Nickolas Appino
 * Class: Side.cs
 * Purpose: A base class representing a side
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side: IOrderItem, INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;

        /// <summary>
        /// Gets the size of the side
        /// </summary>
        public virtual Size Size {
            get
            {
                return size;

            }
            set
            {
                size = value;
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
                if(Size == Size.Small)
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
                if(value == true)
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
        /// Gets the price of the side
        /// </summary>
       // public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; }

    }
}
