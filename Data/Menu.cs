using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
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

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new ChiliCheeseFries());
            items.Add(new CornDodgers());
            items.Add(new PanDeCampo());
            items.Add(new BakedBeans());

            return items.ToArray();
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new JerkedSoda());
            items.Add(new TexasTea());
            items.Add(new CowboyCoffee());
            items.Add(new Water());

            return items.ToArray();
        }

        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new CowpokeChili());
            items.Add(new RustlersRibs());
            items.Add(new PecosPulledPork());
            items.Add(new TrailBurger());
            items.Add(new DakotaDoubleBurger());
            items.Add(new TexasTripleBurger());
            items.Add(new AngryChicken());

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

        public static string[] TypeOfItem
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink",
            };
        }

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

        public static IEnumerable<IOrderItem> FilterByTypeOfItem(IEnumerable<IOrderItem> MenuDisplay, IEnumerable<string> TypeOfItem)
        {


            if (TypeOfItem == null) return MenuDisplay;

            List<IOrderItem> results = new List<IOrderItem>();

            foreach(IOrderItem item in MenuDisplay)
            {
            }

            return null;
        }


    }
}
