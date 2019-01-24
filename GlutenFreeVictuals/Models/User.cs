using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlutenFreeVictuals.Models
{
    public class User : IdentityUser
    {
        private List<Recipe> recipes = new List<Recipe>();
        private List<Rating> ratings = new List<Rating>();

        public string FirstName { get; set; }
       // public string LastName { get; set; }
        

        public ICollection<Recipe> Recipes { get { return recipes; } }
        public ICollection<Rating> Ratings { get { return ratings; } }
    }
}
