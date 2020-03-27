using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;


namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowpokeChiliPropertyChangedTest
    {
        // Test: Cowpoke Chili should implement the INotifyPropertyChanged Interface
        [Fact]
        public void CowpokeChiliShouldImplementINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);

        }

        // Test: Changing "Cheese" property should invoke PropertyChanged for "Cheese"

        // Test: Changing "Cheese" property should invoke PropertyChanged for "SpecialInstructions"

        // Test: Changing "SourCream" property should invoke PropertyChanged for "SourCream"

        // Test: Changing "SourCream" property should invoke PropertyChanged for "SpecialInstructions"

        // Test: Changing "GreenOnions" property should invoke PropertyChanged for "GreenOnions"

        // Test: Changing "GreenOnions" property should invoke PropertyChanged for "SpecialInstructions"

        // Test: Changing "TortillaStrips" property should invoke PropertyChanged for "TortillaStrips"

        // Test: Changing "TortillaStrips" property should invoke PropertyChanged for "SpecialInstructions"

    }
}
