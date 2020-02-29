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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
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

        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new Water());
            }
        }

        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new CowboyCoffee());
            }
        }

        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new TexasTea());
            }
        }

        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new JerkedSoda());
            }
        }

        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new BakedBeans());
            }
        }

        void OnPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new PanDeCampo());
            }
        }

        void OnAddCornDogersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new CornDodgers());
            }
        }

        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new ChiliCheeseFries());
            }
        }

        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new CowpokeChili());
            }
        }

        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new RustlersRibs());
            }
        }

        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new PecosPulledPork());
            }
        }

        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new TrailBurger());
            }
        }

        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new DakotaDoubleBurger());
            }
        }

        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new TexasTripleBurger());
            }
        }

        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data) // checks if you can cast it and if assigns it to data
            {
                data.Add(new AngryChicken());
            }
        }
    }
}
