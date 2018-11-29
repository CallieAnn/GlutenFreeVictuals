using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GlutenFreeVictuals.Models
{
    public class Recipe
    {
        private IEnumerable<Rating> ratings = new List<Rating>();

        public int RecipeId { get; set; }
        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a date")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter instructions")]
        public string Instructions { get; set; }
        [Required(ErrorMessage = "Please enter ingredients")]
        public string Ingredients { get; set; }
        [Required(ErrorMessage = "Please enter prep time")]
        public int PrepTimeMinutes { get; set; }
        [Required(ErrorMessage = "Please enter cook time")]
        public int CookTimeMinutes { get; set; }

        public IEnumerable<Rating> Ratings { get { return ratings; } }
    }
}
