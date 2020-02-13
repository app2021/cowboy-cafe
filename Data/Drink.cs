/*
 * Author: Nickolas Appino
 * Class: Drink.cs
 * Purpose: An abstract class representing a drink
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An abstract class representing a drink
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size { get; set; } = 0; 

        /// <summary>
        /// The price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// If the drink should have ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;

    }
}
