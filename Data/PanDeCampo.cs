/*
 * Author: Nickolas Appino
 * Class: PanDeCampo.cs
 * Purpose: A class for the Pan De Campo side
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class for the Pan De Campo side
    /// </summary>
    public class PanDeCampo: Side
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
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
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
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
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
            return Size + " Pan de Campo";
        }
    }
}
