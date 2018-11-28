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
            List<Recipe> recipies = repo.Recipes;
            recipies.Sort((r1, r2) => string.Compare(r1.Title, r2.Title, StringComparison.Ordinal));
            return View(recipies);
        }

        public IActionResult Recipe(string title)
        {
            ViewData["Message"] = "Individual Recipe";

            Recipe recipe = repo.Recipes.Where(r =>
            {
                return r.Title == title;
            }).FirstOrDefault();
            return View(recipe);
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
