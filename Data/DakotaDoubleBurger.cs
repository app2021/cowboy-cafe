﻿/*
 * Author: Nickolas Appino
 * Class: DakotaDoubleBurger.cs
 * Purpose: A class representing the Dakota Double Burger entree
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{

    /// <summary>
    /// A class representing the Dakota Double Burger entree
    /// </summary>

    public class DakotaDoubleBurger: Entree
    {

        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }

        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// If the entree should have tomatos
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// If the entree should have lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If the entree should have mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

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

                if (!Tomato) { instructions.Add("hold tomato"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }
                if (!Mayo) { instructions.Add("hold mayo"); }
                if (!Bun) { instructions.Add("hold bun"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Cheese) { instructions.Add("hold cheese"); }
                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the item</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }

    }
}
