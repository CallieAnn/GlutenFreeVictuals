using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlutenFreeVictuals.Models
{
    public class User
    {
        private List<Recipe> recipes = new List<Recipe>();
        private List<Rating> ratings = new List<Rating>();

        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Recipe> Recipes { get { return recipes; } }
        public ICollection<Rating> Ratings { get { return ratings; } }
    }
}
