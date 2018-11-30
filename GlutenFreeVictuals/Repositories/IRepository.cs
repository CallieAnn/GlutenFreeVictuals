using GlutenFreeVictuals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlutenFreeVictuals.Repositories
{
    public interface IRepository
    {
        IQueryable<Recipe> Recipes { get; }
        void AddRecipe(Recipe recipe, User user);
        Recipe GetRecipeByTitle(string title);
        void AddRating(Recipe recipe, Rating rating);
    }
}
