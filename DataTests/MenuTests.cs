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




    }
}
