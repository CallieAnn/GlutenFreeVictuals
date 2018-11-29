using System;
using Xunit;
using GlutenFreeVictuals.Models;
using GlutenFreeVictuals.Repositories;
using GlutenFreeVictuals.Controllers;

namespace GlutenFreeVictuals.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void TestAddRecipe()
        {
            //arrange
            var repo = new FakeRepository();
            var homeController = new HomeController(repo);
            //act
            Recipe recipe = new Recipe
            {
                Title = "Buche de Noel",
                Date = DateTime.Parse("11/15/2018"),
                Name = "Clementine",
                Ingredients = "Cream, cocoa, eggs, sugar",
                Instructions = "Start by separating the eggs and whipping the egg whites...",
                PrepTimeMinutes = 20,
                CookTimeMinutes = 15
            };

            User user = new User { Name = recipe.Name };

            homeController.AddRecipe(recipe);

            //assert
            Assert.Equal("Buche de Noel", repo.Recipes[repo.Recipes.Count - 1].Title);
        }
    }
}
