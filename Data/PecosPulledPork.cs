using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork
    {

        /// <summary>
        /// The price of the entree
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// If the entree should be served with bread
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// If the entree should be served with pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// A list of the special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bread) { instructions.Add("hold bread"); }
                if (!Pickle) { instructions.Add("hold pickle"); }

                return instructions;
            }
        }

    }
}
