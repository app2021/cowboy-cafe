/*
 * Author: Nickolas Appino
 * Class: Menu.cs
 * Purpose: Static class used by the website
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// The entres in the menu
        /// </summary>
        /// <returns>A list of the entrees in the menu</returns>
        public static IEnumerable<IOrderItem> Entrees(){

            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new CowpokeChili());
            items.Add(new RustlersRibs());
            items.Add(new PecosPulledPork());
            items.Add(new TrailBurger());
            items.Add(new DakotaDoubleBurger());
            items.Add(new TexasTripleBurger());
            items.Add(new AngryChicken());

            return items.ToArray();
            
        }

        /// <summary>
        /// List of all the sides
        /// </summary>
        /// <returns>List of all the sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> items = new List<IOrderItem>();

            IOrderItem SmallChiliCheeseFries = new ChiliCheeseFries();
            items.Add(SmallChiliCheeseFries);

            IOrderItem MediumChiliCheeseFries = new ChiliCheeseFries();
            MediumChiliCheeseFries.Size = Size.Medium;
            items.Add(MediumChiliCheeseFries);

            IOrderItem LargeChiliCheeseFries = new ChiliCheeseFries();
            LargeChiliCheeseFries.Size = Size.Large;
            items.Add(LargeChiliCheeseFries);

            IOrderItem SmallCornDodgers = new CornDodgers();
            items.Add(SmallCornDodgers);

            IOrderItem MediumCornDodgers = new CornDodgers();
            MediumCornDodgers.Size = Size.Medium;
            items.Add(MediumCornDodgers);

            IOrderItem LargeCornDodgers = new CornDodgers();
            LargeCornDodgers.Size = Size.Large;
            items.Add(LargeCornDodgers);

            IOrderItem SmallPanDeCampo = new PanDeCampo();
            items.Add(SmallPanDeCampo);

            IOrderItem MediumPanDeCampo = new PanDeCampo();
            MediumPanDeCampo.Size = Size.Medium;
            items.Add(MediumPanDeCampo);

            IOrderItem LargePanDeCampo = new PanDeCampo();
            LargePanDeCampo.Size = Size.Large;
            items.Add(LargePanDeCampo);

            IOrderItem SmallBakedBeans = new BakedBeans();
            items.Add(SmallBakedBeans);

            IOrderItem MediumBakedBeans = new BakedBeans();
            MediumBakedBeans.Size = Size.Medium;
            items.Add(MediumBakedBeans);

            IOrderItem LargeBakedBeans = new BakedBeans();
            LargeBakedBeans.Size = Size.Large;
            items.Add(LargeBakedBeans);

            return items.ToArray();
        }

        /// <summary>
        /// List of all the drinks
        /// </summary>
        /// <returns>List of all the drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> items = new List<IOrderItem>();

            IOrderItem SmallJerkedSoda = new JerkedSoda();
            items.Add(SmallJerkedSoda);

            IOrderItem MediumJerkedSoda = new JerkedSoda();
            MediumJerkedSoda.Size = Size.Medium;
            items.Add(MediumJerkedSoda);

            IOrderItem LargeJerkedSoda = new JerkedSoda();
            LargeJerkedSoda.Size = Size.Large;
            items.Add(LargeJerkedSoda);

            IOrderItem SmallTexasTea = new TexasTea();
            items.Add(SmallTexasTea);

            IOrderItem MediumTexasTea = new TexasTea();
            MediumTexasTea.Size = Size.Medium;
            items.Add(MediumTexasTea);

            IOrderItem LargeTexasTea = new TexasTea();
            LargeTexasTea.Size = Size.Large;
            items.Add(LargeTexasTea);

            IOrderItem SmallCowboyCoffee = new CowboyCoffee();
            items.Add(SmallCowboyCoffee);

            IOrderItem MediumCowboyCoffee = new CowboyCoffee();
            MediumCowboyCoffee.Size = Size.Medium;
            items.Add(MediumCowboyCoffee);

            IOrderItem LargeCowboyCoffee = new CowboyCoffee();
            LargeCowboyCoffee.Size = Size.Large;
            items.Add(LargeCowboyCoffee);

            IOrderItem SmallWater = new Water();
            items.Add(SmallWater);

            IOrderItem MediumWater = new Water();
            MediumWater.Size = Size.Medium;
            items.Add(MediumWater);

            IOrderItem LargeWater = new Water();
            LargeWater.Size = Size.Large;
            items.Add(LargeWater);

            return items.ToArray();
        }

        /// <summary>
        /// lisof the complete menu
        /// </summary>
        /// <returns>List of the complete menu</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> items = new List<IOrderItem>();

            IEnumerable<IOrderItem> Entrees = Menu.Entrees();
            foreach (IOrderItem item in Entrees)
            {
                items.Add(item);
            }

            IEnumerable<IOrderItem> Sides = Menu.Sides();
            foreach (IOrderItem item in Sides)
            {
                items.Add(item);
            }

            IEnumerable<IOrderItem> Drinks = Menu.Drinks();
            foreach (IOrderItem item in Drinks)
            {
                items.Add(item);
            }

            return items.ToArray();
        }

        public static string[] TypeOfItem
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink",
            };
        }

        /// <summary>
        /// Filters menu by price
        /// </summary>
        /// <param name="MenuDisplay">the menu to be filtered</param>
        /// <param name="min">the minimum price</param>
        /// <param name="max">the maximum price</param>
        /// <returns>the filtered menu</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> MenuDisplay, double? min, double? max)
        {
            if (min == null && max == null) return MenuDisplay;

            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach(IOrderItem item in MenuDisplay)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            if(max == null)
            {
                foreach(IOrderItem item in MenuDisplay)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            foreach(IOrderItem item in MenuDisplay)
            {
                if(item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filteres menu by calories
        /// </summary>
        /// <param name="MenuDisplay">the menu to be filtered</param>
        /// <param name="min">the minimum calories</param>
        /// <param name="max">the maximum calories</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> MenuDisplay, double? min, double? max)
        {
            if (min == null && max == null) return MenuDisplay;

            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in MenuDisplay)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in MenuDisplay)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in MenuDisplay)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }



        /// <summary>
        /// Filtered menu by a string
        /// </summary>
        /// <param name="MenuDisplay">The menu to be filtered</param>
        /// <param name="terms">The string to fitler by</param>
        /// <returns>The filtered menu</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> MenuDisplay, string terms)
        {
            // TODO: Search database
            List<IOrderItem> results = new List<IOrderItem>();

            // Return all movies if there are no search terms
            if (terms == null) return MenuDisplay;

            // return each movie in the database containing the terms substring
            foreach (IOrderItem item in MenuDisplay)
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters menu by type of item
        /// </summary>
        /// <param name="MenuDisplay">The menu to filter</param>
        /// <param name="types">The type of item to filter by</param>
        /// <returns>The filtered menu</returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> MenuDisplay, string[] types)
        {
            if (types == null || types.Count() == 0) return MenuDisplay;

            List<IOrderItem> items = new List<IOrderItem>();

            if (types.Contains("Entree"))
            {
                IEnumerable<IOrderItem> Entrees = Menu.Entrees();
                foreach(IOrderItem item in Entrees)
                {
                    items.Add(item);
                }
            }

            if(types.Contains("Side"))
            {
                IEnumerable<IOrderItem> Sides = Menu.Sides();
                foreach (IOrderItem item in Sides)
                {
                    items.Add(item);
                }
            }

            if (types.Contains("Drink"))
            {
                IEnumerable<IOrderItem> Drinks = Menu.Drinks();
                foreach (IOrderItem item in Drinks)
                {
                    items.Add(item);
                }

            }

            return items;

        }

    }
}
