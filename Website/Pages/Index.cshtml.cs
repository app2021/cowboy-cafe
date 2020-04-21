using System;
using System.Collections.Generic;
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





        [BindProperty]
        public string SearchTerms { get; set; } = "";

        [BindProperty]
        public string[] TypeOfItem { get; set; }

        [BindProperty]
        public double? CaloriesMin { get; set; }

        [BindProperty]
        public double? CaloriesMax { get; set; }

        [BindProperty]
        public double? PriceMin { get; set; }

        [BindProperty]
        public double? PriceMax { get; set; }

        public IEnumerable<IOrderItem> MenuDisplay { get; protected set; }


        public void OnGet(double? CaloriesMin, double? CaloriesMax, double? PriceMin, double? PriceMax, bool Entree, bool Side, bool Drink)
        {


            MenuDisplay = Menu.CompleteMenu();


            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;

            TypeOfItem = Request.Query["TypeOfItem"];
            SearchTerms = Request.Query["SearchTerms"];

            MenuDisplay = Menu.FilterByPrice(MenuDisplay, PriceMin, PriceMax);
            MenuDisplay = Menu.FilterByCalories(MenuDisplay, CaloriesMin, CaloriesMax);


        }



    }
}
