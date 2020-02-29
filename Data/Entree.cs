/*
 * Author: Nickolas Appino
 * Class: Entree.cs
 * Purpose: An abstract class for the Entree menu items
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An abstract class for the Entrees 
    /// </summary>
    public abstract class Entree: IOrderItem
    {

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
        //public abstract List<string> SpecialInstructions { get; }


    }
}
