using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlutenFreeVictuals.Models
{
    public class User
    {
        private IEnumerable<Recipe> recipes = new List<Recipe>();
        private IEnumerable<Rating> ratings = new List<Rating>();

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public IEnumerable<Recipe> Recipes { get { return recipes; } }
        public IEnumerable<Rating> Ratings { get { return ratings; } }
    }
}
