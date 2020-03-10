/*
 * Author: Nickolas Appino
 * Class: ChiliCheeseFries.cs
 * Purpose: A class representing the Chili Cheese Fries
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chili Cheese Fries
    /// </summary>
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// The calories of the side
        /// </summary>
        public override uint Calories
        {

            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }

        }

        /// <summary>
        /// The price of the side
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the item</returns>
        public override string ToString()
        {
            return Size + " Chili Cheese Fries";
        }

        /// <summary>
        /// Returns an empty list of the Special Instructions
        /// </summary>
        public override List<string> SpecialInstructions { get; }

    }
}
