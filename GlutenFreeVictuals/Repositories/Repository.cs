using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlutenFreeVictuals.Models;
using Microsoft.EntityFrameworkCore;

namespace GlutenFreeVictuals.Repositories
{
    public class Repository : IRepository
    {
        private AppDbContext context;
        public IQueryable<Recipe> Recipes
        {
            get { return context.Recipes.Include("Ratings"); }
        }

        public Repository(AppDbContext appDbContext)
        {
            context = appDbContext;

        }

        public void AddRating(Recipe recipe, Rating rating)
        {
            //Do something to add rating later
        }

        public void AddRecipe(Recipe recipe, User user)
        {
            user.Recipes.Add(recipe);

            context.Recipes.Add(recipe);

            context.SaveChanges();
        }

        public Recipe GetRecipeByTitle(string title)
        {
            Recipe recipe = context.Recipes.First(r => r.Title == title);

            return recipe;
        }
    }
}
