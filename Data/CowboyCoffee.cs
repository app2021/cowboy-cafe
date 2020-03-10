/*
 * Author: Nickolas Appino
 * Class: CowboyCoffee.cs
 * Purpose: A class representing the Cowboy Coffee
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee
    /// </summary>

    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// If it should have ice
        /// </summary>

        private bool ice = false;

        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }



        private bool roomForCream = false;
        /// <summary>
        /// If there should be room for cream
        /// </summary>
        public bool RoomForCream {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                NotifyOfPropertyChange("RoomForCream");
            }
        }



        private bool decaf = false;
        /// <summary>
        /// If the coffee should be decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                NotifyOfPropertyChange("Decaf");
            }
        }

        /// <summary>
        /// The price of the coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Special instructions for the coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                
            
                    List<string> instructions = new List<string>();

                    if (Ice) { instructions.Add("Add Ice"); }
                    if (RoomForCream) { instructions.Add("Room for Cream"); }

                    return instructions;
                
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the item</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return Size + " Decaf Cowboy Coffee";
            }
            else
            {
                return Size + " Cowboy Coffee";
            }
        }
    }
}
