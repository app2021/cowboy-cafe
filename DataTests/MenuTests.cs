using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests
{
    public class MenuTests
    {

        //Test entree cointains all entress

        [Fact]
        public void EntreeMenuContainsAllEntrees(){

            IEnumerable<IOrderItem> entrees = Menu.Entrees();

            foreach(IOrderItem e in entrees)
            {
                Assert.IsAssignableFrom<Entree>(e);

            }
            
        }

        //Entree should contain 7 items

        [Fact]
        public void EntreeContinsSevenItems()
        {
            IEnumerable<IOrderItem> entrees = Menu.Entrees();

            Assert.True(entrees.Count() == 7);
        }

        //Entree should contain item

        [Theory]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(AngryChicken))]
        public void EntreeShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Entrees())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }



        //Test side contains all sides

        [Fact]
        public void SideMenuContainsAllSides()
        {
            IEnumerable<IOrderItem> sides = Menu.Sides();

            foreach (IOrderItem i in sides)
            {
                Assert.IsAssignableFrom<Side>(i);

            }
        }

        //Test side contains 12 items

        [Fact]
        public void TestSideContainsTwelveItems()
        {
            IEnumerable<IOrderItem> side = Menu.Sides();

            Assert.True(side.Count() == 12);
        }


        // Sides should contain item

        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        public void SidesShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach(IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }



        //Test drink contains all drinks

        [Fact]
        public void DrinkMenuContainsAllDrinks()
        {
            IEnumerable<IOrderItem> drinks = Menu.Drinks();

            foreach(IOrderItem i in drinks)
            {
                Assert.IsAssignableFrom<Drink>(i);
            }
        }

        // Test drink contains 12 items

        [Fact]
        public void DrinkMenuContainsTwelveItems()
        {
            IEnumerable<IOrderItem> drinks = Menu.Drinks();

            Assert.True(drinks.Count() == 12);
        }

        // Drinks should contain item

        [Theory]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(Water))]
        public void DrinksShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Drinks())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }


        // Complete menu contains 31 items
        [Fact]
        public void CompleteMenuContains31Items()
        {
            IEnumerable<IOrderItem> menu = Menu.CompleteMenu();

            Assert.True(menu.Count() == 31);
        }

        // Complete menu should contain item

        [Theory]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(Water))]
        public void CompleteMenuShouldContainItem(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.CompleteMenu())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }




        // Search returns correct results

        [Fact]
        public void SearchReturnsCorrectReuslt()
        {

            IEnumerable<IOrderItem> menu = Menu.CompleteMenu();

            IEnumerable<IOrderItem> result = Menu.Search(menu, "ribs");

            var types = new List<Type>();
            foreach(IOrderItem item in result)
            {
                types.Add(item.GetType());
            }

            IOrderItem r = new RustlersRibs();

            Assert.Contains(r.GetType(), types);

        }

        // FilterByType returns correct result with entree
        [Fact]
        public void FilterByTypeReturnsCorrectReusltWithEntree()
        {

            IEnumerable<IOrderItem> menu = Menu.CompleteMenu();

            string[] search = {"Entree"};


            IEnumerable<IOrderItem> result = Menu.FilterByType(menu, search);

            foreach (IOrderItem i in result)
            {
                Assert.IsAssignableFrom<Entree>(i);
            }

        }


        // FilterByType returns correct result with side

        [Fact]
        public void FilterByTypeReturnsCorrectReusltWithSide()
        {

            IEnumerable<IOrderItem> menu = Menu.CompleteMenu();

            string[] search = { "Side" };


            IEnumerable<IOrderItem> result = Menu.FilterByType(menu, search);

            foreach (IOrderItem i in result)
            {
                Assert.IsAssignableFrom<Side>(i);
            }

        }

        // FilterByType returns correct result with drinks

        [Fact]
        public void FilterByTypeReturnsCorrectReusltWithDrinks()
        {

            IEnumerable<IOrderItem> menu = Menu.CompleteMenu();

            string[] search = { "Drink" };


            IEnumerable<IOrderItem> result = Menu.FilterByType(menu, search);

            foreach (IOrderItem i in result)
            {
                Assert.IsAssignableFrom<Drink>(i);
            }

        }


    }
}
