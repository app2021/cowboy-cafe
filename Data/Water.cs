/*
 * Author: Nickolas Appino
 * Class: Water.cs
 * Purpose: A class representing water
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// The price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// The calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// If the water should include a lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Special instructions for the water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if(!Ice) { instructions.Add("Hold Ice"); }
                if(Lemon) { instructions.Add("Add Lemon"); }
                return instructions;

            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the item</returns>
        public override string ToString()
        {
            return Size + " Water";
        }
    }
}
