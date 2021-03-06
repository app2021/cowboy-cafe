﻿/*
 * Author: Nickolas Appino
 * Class: CornDogers.cs
 * Purpose: A class representing the Corn Dodgers side
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Corn Dogers side
    /// </summary>
    public class CornDodgers: Side
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
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
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
            return Size + " Corn Dodgers";
        }

        /// <summary>
        /// Returns an empty list of the SpecialInstructions
        /// </summary>
        public override List<string> SpecialInstructions { get; }

    }
}
