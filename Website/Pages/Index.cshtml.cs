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

        public void OnGet()
        {

        }

        /// <summary>
        /// Returns Entree Menu
        /// </summary>
        /// <returns>String of Entree Menu</returns>
        public static string Entrees()
        {

            StringBuilder sb = new StringBuilder();

            IEnumerable<IOrderItem> items = Menu.Entrees();

            foreach(IOrderItem item in items)
            {
                sb.Append("<div class=\"menu-item\">");
                sb.Append(item);
                sb.Append("<br>");
                sb.Append("Calories: ");
                sb.Append(item.Calories);
                sb.Append("<br>");
                sb.Append("Price: ");
                sb.Append(item.Price.ToString("C"));
                sb.Append("</div>");
                sb.Append("<br>");
            }

            return sb.ToString();
        }

        /// <summary>
        /// Sides Menu
        /// </summary>
        /// <returns>String of Sides Menu</returns>
        public static string Sides()
        {
            IEnumerable<IOrderItem> items = Menu.Sides();

            StringBuilder sb = new StringBuilder();


            foreach (IOrderItem item in items)
            {

                item.Size = Size.Small;

                sb.Append("<div class=\"menu-item\">");
                sb.Append(item);
                sb.Append("<br>");
                sb.Append("Calories: ");
                sb.Append(item.Calories);
                sb.Append("<br>");
                sb.Append("Price: ");
                sb.Append(item.Price.ToString("C"));
                sb.Append("</div>");
                sb.Append("<br>");

                item.Size = Size.Medium;

                sb.Append("<div class=\"menu-item\">");
                sb.Append(item);
                sb.Append("<br>");
                sb.Append("Calories: ");
                sb.Append(item.Calories);
                sb.Append("<br>");
                sb.Append("Price: ");
                sb.Append(item.Price.ToString("C"));
                sb.Append("</div>");
                sb.Append("<br>");

                item.Size = Size.Large;

                sb.Append("<div class=\"menu-item\">");
                sb.Append(item);
                sb.Append("<br>");
                sb.Append("Calories: ");
                sb.Append(item.Calories);
                sb.Append("<br>");
                sb.Append("Price: ");
                sb.Append(item.Price.ToString("C"));
                sb.Append("</div>");
                sb.Append("<br>");


            }

            return sb.ToString();
        }

        /// <summary>
        /// Drinks Menu
        /// </summary>
        /// <returns>String of the drinks menu</returns>
        public static string Drinks()
        {
            IEnumerable<IOrderItem> items = Menu.Drinks();

            StringBuilder sb = new StringBuilder();


            foreach (IOrderItem item in items)
            {

                item.Size = Size.Small;

                sb.Append("<div class=\"menu-item\">");
                sb.Append(item);
                sb.Append("<br>");
                sb.Append("Calories: ");
                sb.Append(item.Calories);
                sb.Append("<br>");
                sb.Append("Price: ");
                sb.Append(item.Price.ToString("C"));
                sb.Append("</div>");
                sb.Append("<br>");

                item.Size = Size.Medium;

                sb.Append("<div class=\"menu-item\">");
                sb.Append(item);
                sb.Append("<br>");
                sb.Append("Calories: ");
                sb.Append(item.Calories);
                sb.Append("<br>");
                sb.Append("Price: ");
                sb.Append(item.Price.ToString("C"));
                sb.Append("</div>");
                sb.Append("<br>");

                item.Size = Size.Large;

                sb.Append("<div class=\"menu-item\">");
                sb.Append(item);
                sb.Append("<br>");
                sb.Append("Calories: ");
                sb.Append(item.Calories);
                sb.Append("<br>");
                sb.Append("Price: ");
                sb.Append(item.Price.ToString("C"));
                sb.Append("</div>");
                sb.Append("<br>");


            }

            return sb.ToString();
        }

    }
}
