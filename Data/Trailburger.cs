using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trailburger entree
    /// </summary>
    public class Trailburger
    {

        /// <summary>
        /// The price of the entree
        /// </summary>
        public double Price
        {
            get
            {
                return 4.50;
            }

        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return 288;
            }
        }

    }
}
