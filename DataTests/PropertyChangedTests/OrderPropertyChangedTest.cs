using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{

    class MockOrderItem : IOrderItem
    {
        public new double Price { get; set; }
        public new List<string> SpecialInstructions { get; set; }

    }

    public class OrderPropertyChangedTest
    {
        // Test: Order should implement the INotifyPropertyChanged Interface
        [Fact]
        public void OrderShouldImplementINotifyPropertyChanged()
        {
            var order = new Order();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        // Test: Adding an item should invoke PropertyChanged for item
        [Fact]
        public void AddingItemShouldInvokePropertyChangedForItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, "Items", () =>
            {
                order.Add(item);
            });
        }

        // Test: Adding an item should invoke PropertyChanged for Subtotal
        [Fact]
        public void AddingItemShouldInvokePropertyChangedForSubtotal()
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(item);
            });
        }



        // Test: Removing an item should invoke PropertyChanged for item
        [Fact]
        public void RemovingItemShouldInvokePropertyChangedForItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, "Items", () =>
            {
                order.Remove(item);
            });
        }

        // Test: Removing an item should invoke PropertyChanged for subtotal
        [Fact]
        public void RemovingItemShouldInvokePropertyChangedForSubtotal()
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(item);
            });
        }



    }
}
