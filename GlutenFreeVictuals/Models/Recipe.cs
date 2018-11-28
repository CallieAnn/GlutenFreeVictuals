using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlutenFreeVictuals.Models
{
    public class Recipe
    {
        private IEnumerable<Rating> ratings = new List<Rating>();

        public int RecipeId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Instructions { get; set; }
        public string Ingredients { get; set; }
        public string SourceUrl { get; set; }
        public int PrepTimeMinutes { get; set; }
        public int CookTimeMinutes { get; set; }

        public IEnumerable<Rating> Ratings { get { return ratings; } }
    }
}
