/*
 * Author: Nickolas Appino
 * Class: RustlersRibs
 * Purpose: A class for the Rustlers Ribs entree
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Ruster's Ribs
    /// </summary>
    public class RustlersRibs: Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }

        }

        /// <summary>
        /// An empty list of the Special Instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
        }
    }
}
