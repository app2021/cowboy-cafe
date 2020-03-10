/*
 * Author: Nickolas Appino
 * Class: CowpokeChili.cs
 * Purpose: A class representing the Cowpoke Chili entree
 */

using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili: Entree
    {
        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>

        private bool cheese = true;
        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { 

                cheese = value;
                NotifyOfPropertyChange("Cheese");

            }
        }

        /// <summary>
        /// If there should be sour cream
        /// </summary>
        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream
        {
            get { return sourCream; }
            set { 
                
                sourCream = value;
                NotifyOfPropertyChange("SourCream");

            }
        }

        /// <summary>
        /// If there should be green onions
        /// </summary>
        private bool greenOnions = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions
        {
            get { return greenOnions; }
            set { 
                
                greenOnions = value;
                NotifyOfPropertyChange("GreenOnions");

            }
        }

        /// <summary>
        /// If there should be Tortilla Strips
        /// </summary>
        private bool tortillaStrips = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips
        {
            get { return tortillaStrips; }
            set { 
                
                tortillaStrips = value;
                NotifyOfPropertyChange("TortillaStrips");
            }
        }

        /// <summary>
        /// The price of the chili
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold cheese");
                if (!sourCream) instructions.Add("hold sour cream");
                if (!greenOnions) instructions.Add("hold green onions");
                if (!tortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the Cowpoke Chili</returns>
        public override string ToString()
        {
            return "Cowpoke Chili";
        }



    }
}

