using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class ChiliCheeseFriesPropertyChangedTest
    {
        // Test 1: Chili Cheese Fries should implement the INotifyPropertyChanged Interface
        [Fact]
        public void ChiliCheeseFrieesShouldImplementINotifyPropertyChanged()
        {
            var chili = new ChiliCheeseFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }

        // Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Size", () =>
            {
                fries.Size = Size.Large;
            });
        }

        // Test 3: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Calories", () =>
            {
                fries.Size = Size.Large;
            });
        }

        // Test 4: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var fries = new ChiliCheeseFries();
            Assert.PropertyChanged(fries, "Price", () =>
            {
                fries.Size = Size.Large;
            });
        }

    }
}
