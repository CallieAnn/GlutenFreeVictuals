using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlutenFreeVictuals.Models;

namespace GlutenFreeVictuals.Repositories
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.Migrate();

            if (!context.Recipes.Any())
            {
                User u = new User();
                DateTime rDate;
                DateTime.TryParse("10/10/2018", out rDate);
                Recipe r = new Recipe
                {
                    Name = "Eva",
                    Title = "Cornish Pasties",
                    Date = rDate,
                    Ingredients = "Flour, beef, mushrooms, onions, cheese...",
                    Instructions = "Cook the beef and onion in a pan...",
                    CookTimeMinutes = 45,
                    PrepTimeMinutes = 20
                };
                u.FirstName = r.Name;

                u.Recipes.Add(r);

                User u2 = new User
                {
                    FirstName = "William"
                };

                DateTime r2Date;
                DateTime.TryParse("11/28/2018", out r2Date);
                Recipe r2 = new Recipe
                {
                    Name = u2.FirstName,
                    Title = "Fajitas",
                    Date = r2Date,
                    Ingredients = "chicken, cilantro, onions, cheese, tortillas...",
                    Instructions = "Cook the chicken in a pan until opaque...",
                    CookTimeMinutes = 30,
                    PrepTimeMinutes = 15
                };
                

                u2.Recipes.Add(r2);

                context.Users.Add(u);
                context.Users.Add(u2);

                context.Recipes.Add(r);
                context.Recipes.Add(r2);

                context.SaveChanges();
            }
        }
    }
}
