using FinalProject.models;
using Microsoft.EntityFrameworkCore;
namespace FinalProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RecipeContext(
                serviceProvider.GetRequiredService<DbContextOptions<RecipeContext>>()))
            {
                // Look for any blogs.
                if (context.Recipes.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Recipes.AddRange(
                    new Recipe
                    {
                       RecipeId ="1",
                        Title="Slow Cooker Dr.Pepper PorkChops",
                        DateAdded = "April 24, 2024",
                        TimeToCook = "4-6 hours (slow cooker)",
                        Description = "1) Season Porkchops with flour, salt and pepper. 2) Lightly brown Porkchops in a pan. 3)Add 1 can of cream of mushroom, 1 can of cranberry sauce, 1 can of Drpepper, and the porkchops into the slow cooker 4)Cook on medium for 4-6 hours 5)Enjoy!",
                        Author = "Paige W"
                    },
                    new Recipe
                    {
                        RecipeId="2",
                        Title = "Ground Beef Spaghetti",
                        DateAdded="April 24, 2024",
                        TimeToCook = "30 minutes",
                        Description ="1) Place ground beef in a pan cook until done 2)while cooking the ground beef, add spagetti to a pot of boiling water 3)add seasonings to ground beef 4)in a sauce pan add your favorite can of pasta sauce. 5)Combine and Enjoy!",
                        Author ="Paige W"
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}
