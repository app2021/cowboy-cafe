/*
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
        /// If there should be tomatos
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// If the entree should have tomatos
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                NotifyOfPropertyChange("Tomato");
            }
        }

        /// <summary>
        /// If there should be lettuce
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// If the entree should have lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                NotifyOfPropertyChange("Lettuce");
            }
        }


        /// <summary>
        /// If there should be mayo
        /// </summary>
        private bool mayo = true;
        /// <summary>
        /// If the entree should have mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                NotifyOfPropertyChange("Mayo");
            }
        }

        /// <summary>
        /// If there should be bun
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
        /// If there should be ketchup
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
        /// If there should be mustard
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
        /// If there should be a pickle
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
        /// If there should be cheese
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
