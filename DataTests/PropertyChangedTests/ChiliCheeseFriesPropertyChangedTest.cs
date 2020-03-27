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
    }
}
