﻿/*
 * Author: Nickolas Appino
 * Class: TexasTripleBurger
 * Purpose: A class representing the Texas Triple Burger
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger
    /// </summary>
    public class TexasTripleBurger: Entree
    {

        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }

        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// If there is an egg
        /// </summary>
        private bool egg = true;
        /// <summary>
        /// If the entree should have egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                NotifyOfPropertyChange("Egg");
            }
        }

        /// <summary>
        /// If there is bacon
        /// </summary>
        private bool bacon = true;
        /// <summary>
        /// If the entree should have bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
                NotifyOfPropertyChange("Bacon");
            }
        }

        /// <summary>
        /// if there is tomato
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
        /// if there is lettuce
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
        /// if there is mayo
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
        /// if there is mustard
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// If the entree should have mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard;}
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
        /// to cheese or not to cheese
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

                if (!Egg) { instructions.Add("hold egg"); }
                if (!Bacon) { instructions.Add("hold bacon"); }
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
            return "Texas Triple Burger";
        }

    }


}
