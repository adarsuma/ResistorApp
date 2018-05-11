using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ResistorWebApp.ViewModel
{
    public static class DropdownHelper
    {
        public static IEnumerable<SelectListItem> GetBandColors()
        {
            var options = new Dictionary<string, string>
            {
                { "BLACK", "black" },
                { "BROWN", "brown" },
                { "RED", "red" },
                { "ORANGE", "orange" },
                { "YELLOW", "yellow" },
                { "GREEN", "green" },
                { "BLUE", "blue" },
                { "VIOLET", "violet" },
                { "GRAY", "gray" },
                { "WHITE", "white" }
            };
            return options.Select(x => new SelectListItem { Text = x.Key, Value = x.Value });
        }

        public static IEnumerable<SelectListItem> GetMultiplierColors()
        {
            var options = new Dictionary<string, string>
            {
                { "PINK", "pink" },
                { "SILVER", "silver" },
                { "GOLD", "gold" },
                { "BLACK", "black" },
                { "BROWN", "brown" },
                { "RED", "red" },
                { "ORANGE", "orange" },
                { "YELLOW", "yellow" },
                { "GREEN", "green" },
                { "BLUE", "blue" },
                { "VIOLET", "violet" },
                { "GRAY", "gray" },
                { "WHITE", "white" }
            };
            return options.Select(x => new SelectListItem { Text = x.Key, Value = x.Value });
        }

        public static IEnumerable<SelectListItem> GetToleranceColors()
        {
            var options = new Dictionary<string, string>
            {
                { "NONE", "none" },                
                { "SILVER", "silver" },
                { "GOLD", "gold" },                
                { "BROWN", "brown" },
                { "RED", "red" },                
                { "YELLOW", "yellow" },
                { "GREEN", "green" },
                { "BLUE", "blue" },
                { "VIOLET", "violet" },
                { "GRAY", "gray" }
            };
            return options.Select(x => new SelectListItem { Text = x.Key, Value = x.Value });
        }
    }
}