using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlutenFreeVictuals.Models;

namespace GlutenFreeVictuals.Repositories
{
    public class FakeRepository : IRepository
    {
        private List<Recipe> recipes = new List<Recipe>();
        public List<Recipe> Recipies { get {return recipes; } }

        public FakeRepository()
        {
            AddFakeData();
        }

        public void AddRating(Recipe recipe, Rating rating)
        {
            //add a rating later
        }

        public void AddRecipe(Recipe recipe, User user)
        {
            recipes.Add(recipe);
        }

        public Recipe GetRecipeByTitle(string title)
        {
            Recipe recipe = recipes.Find(r => r.Title == title);
            return recipe;
        }

        public void AddFakeData()
        {
            Recipe firstRecipe = new Recipe
            {
                Title = "Apple Pie",
                Author = "Patricia",
                Date = DateTime.Now,
                Ingredients = "Flour, apples, sugar, butter, cinnamon",
                Instructions = "Measure the flour...",
                PrepTimeMinutes = 10,
                CookTimeMinutes = 50,
                SourceUrl = ""
            };

            recipes.Add(firstRecipe);
        }
    }
}
