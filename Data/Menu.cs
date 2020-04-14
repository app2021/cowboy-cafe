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

            items.Add(new ChiliCheeseFries());
            items.Add(new CornDodgers());
            items.Add(new PanDeCampo());
            items.Add(new BakedBeans());

            items.Add(new JerkedSoda());
            items.Add(new TexasTea());
            items.Add(new CowboyCoffee());
            items.Add(new Water());

            return items.ToArray();
        }

    }
}
