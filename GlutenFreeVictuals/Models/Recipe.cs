using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GlutenFreeVictuals.Models
{
    public class Recipe
    {
        private List<Rating> ratings = new List<Rating>();

        public int RecipeID { get; set; }
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

        public ICollection<Rating> Ratings { get { return ratings; } }
    }
}
