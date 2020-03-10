/*
 * Author: Nickolas Appino
 * Class: JerkedSoda.cs
 * Purpose: A class representing Jerked Soda
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing Jerked Soda
    /// </summary>
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// The price of the soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The flavor of the soda
        /// </summary>
        private SodaFlavor flavor;

        /// <summary>
        /// The flavor of the soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Flavor");
                NotifyOfPropertyChange("CreamSoda");
                NotifyOfPropertyChange("OrangeSoda");
                NotifyOfPropertyChange("Sarsparilla");
                NotifyOfPropertyChange("BirchBeer");
                NotifyOfPropertyChange("RootBeer");

            }
        }

        /// <summary>
        /// If the flavor is Birch Beer
        /// </summary>
        public bool BirchBeer
        {
            get
            {
                if(Flavor == SodaFlavor.BirchBeer)
                {
                    return true;
                }

                return false;

            }
            set
            {
                Flavor = SodaFlavor.BirchBeer;
            }
  
        }

        /// <summary>
        /// If the flavor is CreamSoda
        /// </summary>
        public bool CreamSoda
        {
            get
            {
                if (Flavor == SodaFlavor.CreamSoda)
                {
                    return true;
                }

                return false;

            }
            set
            {
                Flavor = SodaFlavor.CreamSoda;
            }

        }


        /// <summary>
        /// If the flavor is Orange Soda
        /// </summary>
        public bool OrangeSoda
        {
            get
            {
                if (Flavor == SodaFlavor.OrangeSoda)
                {
                    return true;
                }

                return false;

            }
            set
            {
                Flavor = SodaFlavor.OrangeSoda;
            }

        }

        /// <summary>
        /// If the flavor is Sarsparilla
        /// </summary>
        public bool Sarsparilla
        {
            get
            {
                if (Flavor == SodaFlavor.Sarsparilla)
                {
                    return true;
                }

                return false;

            }
            set
            {
                Flavor = SodaFlavor.Sarsparilla;
            }

        }

        /// <summary>
        /// If the flavor is RootBeer
        /// </summary>
        public bool RootBeer
        {
            get
            {
                if (Flavor == SodaFlavor.RootBeer)
                {
                    return true;
                }

                return false;

            }
            set
            {
                Flavor = SodaFlavor.RootBeer;
            }

        }

    


        /// <summary>
        /// If there should be ice
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// If there should be ice
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                NotifyOfPropertyChange("Ice");
                NotifyOfPropertyChange("SpecialInstructions");

            }

        }

        /// <summary>
        /// Special instructions for the soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
           
                    List<string> instructions = new List<string>();

                    if (!Ice) { instructions.Add("Hold Ice"); }

                    return instructions;
                
            }
        }

        /// <summary>
        /// Returns the string representation of this object
        /// </summary>
        /// <returns>The string describing the item</returns>
        public override string ToString()
        {
            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    return Size + " Birch Beer Jerked Soda";
                case SodaFlavor.CreamSoda:
                    return Size + " Cream Soda Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return Size + " Orange Soda Jerked Soda";
                case SodaFlavor.RootBeer:
                    return Size + " Root Beer Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return Size + " Sarsparilla Jerked Soda";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
