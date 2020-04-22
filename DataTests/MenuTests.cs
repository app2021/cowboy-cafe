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

        //Test menu entree cointains all entress

        [Fact]
        public void MenuEntreeContainsAllEntrees(){
            IEnumerable<IOrderItem> menu = Menu.Entrees();
            foreach(IOrderItem i in menu)
            {
                Assert.Contains(i, menu);
            }
        }


        [Fact]
        public void TestSearch()
        {
            IEnumerable<IOrderItem> menu = Menu.CompleteMenu();

            IEnumerable<IOrderItem> search = Menu.Search(menu, "Ribs");

            foreach(IOrderItem i in search)
            {
                Assert.Contains(i, search);
            }
        }

        [Theory]





    }
}
