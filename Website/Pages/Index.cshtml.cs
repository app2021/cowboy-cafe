using System;
using System.Collections.Generic;
/*
 * Author: Nickolas Appino
 * Class: Index.cshtml.cs
 * Purpose: Interaction logic for index page
 */

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;
using System.Text;
using System.Reflection.Metadata;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }



        #region Variables

        /// <summary>
        /// The terms to search for
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// The types of items
        /// </summary>
        [BindProperty]
        public string[] TypeOfItem { get; set; }

        /// <summary>
        /// The minimum calories
        /// </summary>
        [BindProperty]
        public double? CaloriesMin { get; set; }

        /// <summary>
        /// The max calories
        /// </summary>
        [BindProperty]
        public double? CaloriesMax { get; set; }

        /// <summary>
        /// The min price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// The max price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        public IEnumerable<IOrderItem> MenuDisplay { get; protected set; }

        #endregion 

        /// <summary>
        /// When the pages loads
        /// </summary>
        /// <param name="CaloriesMin">Min Calories</param>
        /// <param name="CaloriesMax">Max Calories</param>
        /// <param name="PriceMin">Min Price</param>
        /// <param name="PriceMax">Max Price</param>
        public void OnGet(double? CaloriesMin, double? CaloriesMax, double? PriceMin, double? PriceMax)
        {


            MenuDisplay = Menu.CompleteMenu();

            #region Variables

            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            TypeOfItem = Request.Query["TypeOfItem"];
            SearchTerms = Request.Query["SearchTerms"];

            #endregion


            //            MenuDisplay = Menu.FilterByType(MenuDisplay, TypeOfItem);
            //            MenuDisplay = Menu.Search(MenuDisplay, SearchTerms);
            //            MenuDisplay = Menu.FilterByPrice(MenuDisplay, PriceMin, PriceMax);
            //            MenuDisplay = Menu.FilterByCalories(MenuDisplay, CaloriesMin, CaloriesMax);


            #region TypeOfItem

            if (TypeOfItem != null && TypeOfItem.Count() != 0)
            {

                if(TypeOfItem.Contains("Entree") && TypeOfItem.Contains("Side") && TypeOfItem.Contains("Drink"))
                {

                }
                else if( TypeOfItem.Contains("Entree") && TypeOfItem.Contains("Side") && !TypeOfItem.Contains("Drink"))
                {
                    MenuDisplay = (MenuDisplay.Where(item =>
                    item as Entree != null ||
                    item as Side != null
                    ));
                }
                else if (TypeOfItem.Contains("Entree") && !TypeOfItem.Contains("Side") && !TypeOfItem.Contains("Drink"))
                {
                    MenuDisplay = (MenuDisplay.Where(item =>
                    item as Entree != null
                    ));

                }
                else if (!TypeOfItem.Contains("Entree") && TypeOfItem.Contains("Side") && !TypeOfItem.Contains("Drink"))
                {
                    MenuDisplay = (MenuDisplay.Where(item =>
                    item as Side != null
                    ));
                }
                else if (!TypeOfItem.Contains("Entree") && !TypeOfItem.Contains("Side") && TypeOfItem.Contains("Drink"))
                {
                    MenuDisplay = (MenuDisplay.Where(item =>
                    item as Drink != null
                    ));

                }
                else if (!TypeOfItem.Contains("Entree") && TypeOfItem.Contains("Side") && TypeOfItem.Contains("Drink"))
                {
                    MenuDisplay = (MenuDisplay.Where(item =>
                    item as Side != null ||
                    item as Drink != null
                    ));
                }
                else if (TypeOfItem.Contains("Entree") && !TypeOfItem.Contains("Side") && TypeOfItem.Contains("Drink"))
                {
                    MenuDisplay = (MenuDisplay.Where(item =>
                    item as Entree != null ||
                    item as Drink != null
                    ));
                }

            }
            #endregion

            #region Search

            if (SearchTerms != null)
            {

                MenuDisplay = (MenuDisplay.Where(item =>
                item.ToString() != null &&
                item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                ));
            }


            #endregion

            #region Filter By Price

            if(PriceMin != null || PriceMax != null)
            {
                if(PriceMin == null)
                {
                    MenuDisplay = MenuDisplay.Where(item =>
                    item.Price <= PriceMax
                    );
                }
                else if(PriceMax == null)
                {
                    MenuDisplay = MenuDisplay.Where(item =>
                    item.Price >= PriceMin
                    );
                }
                else
                {
                    MenuDisplay = MenuDisplay.Where(item =>
                    item.Price >= PriceMin && item.Price <= PriceMax
                    );
                }
            }

            #endregion

            #region Filter By Calories

            if(CaloriesMin != null || CaloriesMax != null)
            {
                if(CaloriesMin == null)
                {
                    MenuDisplay = MenuDisplay.Where(item =>
                    item.Calories < CaloriesMax
                    );
                }
                else if(CaloriesMax == null)
                {
                    MenuDisplay = MenuDisplay.Where(item =>
                    item.Calories >= CaloriesMax
                    );
                }
                else
                {
                    MenuDisplay = MenuDisplay.Where(item =>
                    item.Calories >= CaloriesMin && item.Calories <= CaloriesMax
                    );
                }
            }

            #endregion


        }

    }
}
