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
        public IQueryable<Recipe> Recipes { get { return recipes.AsQueryable(); } }

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
                Name = "Patricia",
                Date = DateTime.Now,
                Ingredients = "Flour, apples, sugar, butter, cinnamon",
                Instructions = "Measure the flour...",
                PrepTimeMinutes = 10,
                CookTimeMinutes = 50,
               
            };

            recipes.Add(firstRecipe);

            Recipe secondRecipe = new Recipe
            {
                Title = "Three Bean Salad",
                Name = "Rick",
                Date = DateTime.Now,
                Ingredients = "kidney beans, garbanzo beans, green beans, olive oil, garlic, apple cider vinegar",
                Instructions = "Combine the beans...",
                PrepTimeMinutes = 20,
                CookTimeMinutes = 0,

            };

            recipes.Add(secondRecipe);
        }
    }
}
