/*
 * Author: Nickolas Appino
 * Class: TrailBurger.cs
 * Purpose: A class representing the Trailburger entree
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trailburger entree
    /// </summary>
    public class TrailBurger: Entree
    {

        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }

        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// If the entree should have a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If the entree should have ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If the entree should have mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If the entree should have pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If the entree should have cheese
        /// </summary>
        public bool Cheese { get; set; } = true;
        /// <summary>
        /// A list of the special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bun) { instructions.Add("hold bun"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Cheese) { instructions.Add("hold cheese"); }

                return instructions;
            }
        }

        public override string ToString()
        {
            return "Trail Burger";
        }

    }
}
