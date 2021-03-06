﻿/*
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
        /// If there should be lemon
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// If the water should include a lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                NotifyOfPropertyChange("Lemon");
            }
        }

        /// <summary>
        /// if there should be ice
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// if there should be ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }
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
