using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public class IOrderItem
    {
        /// <summary>
        /// The price of this order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The special instructions for this IOrderItem
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
