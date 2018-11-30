using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlutenFreeVictuals.Models;
using System.Web;
using GlutenFreeVictuals.Repositories;

namespace GlutenFreeVictuals.Controllers
{
    public class HomeController : Controller
    {
        IRepository repo;

        public HomeController(IRepository r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Recipes()
        {
            ViewData["Message"] = "This is where you can browse the recipes, or search.";
            List<Recipe> recipes = repo.Recipes.ToList();
            recipes.Sort((r1, r2) => string.Compare(r1.Title, r2.Title, StringComparison.Ordinal));
            return View(recipes);
        }

        [HttpPost]
        public IActionResult Recipes(string title)
        {
            //List<Recipe> recipes = repo.Recipes.Where(rec =>
            //{
            //    return rec.Title == title;
            //}).ToList();
            List<Recipe> recipes = (from r in repo.Recipes
                                    where r.Title == title
                                    select r).ToList();

            return View(recipes);
        }

        public IActionResult Recipe(string title)
        {
            ViewData["Message"] = "Individual Recipe";

            //Recipe recipe = repo.Recipes.Where(r =>
            //{
            //    return r.Title == title;
            //}).FirstOrDefault();
            //return View(recipe);

            Recipe recipe = (from r in repo.Recipes
                             where r.Title == title
                             select r).FirstOrDefault();

            return View(recipe);
        }

        [HttpGet]
        public IActionResult AddRecipe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                //create new user for name entered in story form
                User u = new User()
                {
                    Name = recipe.Name
                };

                //add story and corresponding user to repository
                repo.AddRecipe(recipe, u);

                return RedirectToAction("Recipes");
            }

            else
            {
                //validation error
                return View();
            }
            
        }

        public IActionResult Converter()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
