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

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }




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


            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            TypeOfItem = Request.Query["TypeOfItem"];
            SearchTerms = Request.Query["SearchTerms"];

            MenuDisplay = Menu.FilterByType(MenuDisplay, TypeOfItem);
            MenuDisplay = Menu.Search(MenuDisplay, SearchTerms);
            MenuDisplay = Menu.FilterByPrice(MenuDisplay, PriceMin, PriceMax);
            MenuDisplay = Menu.FilterByCalories(MenuDisplay, CaloriesMin, CaloriesMax);


        }



    }
}
