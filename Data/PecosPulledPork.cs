﻿/*
 * Author: Nickolas Appino
 * Class: PecosPulledPork.cs
 * Purpose: A class for the Pecos Pulled Pork entree
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork: Entree
    {

        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// If there should be bread
        /// </summary>
        private bool bread = true;

        /// <summary>
        /// If the entree should be served with bread
        /// </summary>
        public bool Bread {
            get { return bread; } 
            set
            {
                bread = value;
                NotifyOfPropertyChange("Bread");
            } 
        }

        /// <summary>
        /// If there should be a pickle
        /// </summary>
        public bool pickle = true;

        /// <summary>
        /// If the entree should be served with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        /// <summary>
        /// A list of the special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the item</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }

    }
}
