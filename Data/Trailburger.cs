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
    public class TrailBurger : Entree
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
        /// if there is a bun
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// If the entree should have a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                NotifyOfPropertyChange("Bun");
            }
        }

        /// <summary>
        /// if there is ketchup
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// If the entree should have ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                NotifyOfPropertyChange("Ketchup");
            }
        }

        /// <summary>
        /// if there is msutard
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// If the entree should have mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                NotifyOfPropertyChange("Mustard");
            }
        }

        /// <summary>
        /// if there is pickle
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// If the entree should have pickles
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
        /// if there is cheese
        /// </summary>
        private bool cheese = true;
        /// <summary>
        /// If the entree should have cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                NotifyOfPropertyChange("Cheese");
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
            return "Trail Burger";
        }

    }
}
