/*
 * Author: Nickolas Appino
 * Class: MenuItemSelectionControl.xaml.cs
 * Purpose: Interaction logic for MenuItemSelectionControl.xaml
 */ 

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CowboyCafe.Extensions;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {

        private OrderControl orderControl;
        /// <summary>
        /// Interaction logic for MenuItemSelectionControl.xaml
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();


            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;

            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDogersButtonClicked;
            AddPanDeCampoButton.Click += OnPanDeCampoButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;

            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
        }

        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                var entree = new CowpokeChili();
                var screen = new CustomizeCowpokeChili();
                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new RustlersRibs());

            }
        }

        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                var entree = new PecosPulledPork();
                var screen = new CustomizePecosPulledPork();
                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                var entree = new TrailBurger();
                var screen = new CustomizeTrailBurger();
                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                var entree = new DakotaDoubleBurger();
                var screen = new CustomizeDakotaDoubleBurger();
                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                var entree = new TexasTripleBurger();
                var screen = new CustomizeTexasTripleBurger();
                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                var entree = new AngryChicken();
                var screen = new CustomizeAngryChicken();
                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                var entree = new ChiliCheeseFries();
                var screen = new CustomizeSide();
                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }

        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDogersButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                var entree = new CornDodgers();
                var screen = new CustomizeSide();
                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }


        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                var entree = new PanDeCampo();
                var screen = new CustomizeSide();
                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }


        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                var entree = new BakedBeans();
                var screen = new CustomizeSide();
                AddItemAndOpenCustomizationScreen(entree, screen);

            }
        }



        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new Water());
            }
        }

        
        /*
        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order) {

                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            order.Add(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowpokeChili());
                            break;
                        }
                }
            }
            */

        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new TexasTea());
            }
        }

        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new JerkedSoda());
            }
        }















        /// <summary>
        /// Adds Item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>




        void AddItemAndOpenCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if(order == null) throw new Exception("DataContext expected to be an Order instance");

            if(screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor of OrderControl expected");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }

            order.Add(item);
        }
    }
}
