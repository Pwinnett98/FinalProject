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
                
                if (context.Recipes.Any())
                {
                    return; 
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
                    },
                    new Recipe
                    {
                        RecipeId ="3",
                        Title ="Lemon Pepper Chicken and rice",
                        DateAdded = "April 24, 2024",
                        TimeToCook ="30 minutes",
                        Description="1)season chicken with lemon pepper seasoning 2)put chicken into the oven to bake 3)when the chicken has 10 minutes left cook your rice 4)enjoy your meal!",
                        Author="Paige W"
                    },
                    new Recipe
                    {
                        RecipeId="4",
                        Title = "beef soft tacos",
                        DateAdded = "April 24, 2024",
                        TimeToCook ="30 minutes",
                        Description ="1) brown meat 2)heat up tortillas 3)combine and add your favorite soft taco topings 4)enjoy your meal!",
                        Author ="Paige W"
                    },
                    new Recipe
                    {
                        RecipeId="5",
                        Title = "chicken soft tacos",
                        DateAdded = "April 24, 2024",
                        TimeToCook ="30 minutes",
                        Description ="1) boil chicken 2)heat up tortillas 3)shred chicken once it is done boiling 4)combine and add your favorite soft taco topings 5)enjoy your meal!",
                        Author ="Paige W"
                    },
                    new Recipe
                    {
                        RecipeId = "6",
                        Title = "Baked Potatoes",
                        DateAdded="April 24, 2024",
                        TimeToCook="1 hour",
                        Description="1) wash and place potatoes in foil 2)bake potatoes till done 3)add your favorite topings 4)enjoy your meal!",
                        Author="Paige W"
                    },
                    new Recipe
                    {
                        RecipeId = "7",
                        Title = "italian chicken",
                        DateAdded="April 25, 2024",
                        TimeToCook="30 minutes",
                        Description="1) wash chicken and add to a bag 2)add italian dressing to chicken 3)let chicken marinate for an hour or overnight 4)add chicken to a pan with vegitable of your choice 5) cook for 20-25 minutes in the oven at 425 degrees 6)Enjoy your meal",
                        Author="Paige W"
                    },
                    new Recipe 
                    {
                        RecipeId = "8",
                        Title = "strawberry goatcheese salad",
                        DateAdded="April 25, 2024",
                        TimeToCook="15 minutes (no cooking needed)",
                        Description="1) combine your favorite blends of greens 2) add chopped up strawberries 3)add feta or goat cheese 4)add chopped up walnuts or almonds and some blueberries 5)top with a fruit vinagrette of your choice 6)enjoy your meal",
                        Author="Paige W"
                    },
                    new Recipe 
                    {
                        RecipeId = "9",
                        Title = "chicken Fetichini alfredo",
                        DateAdded="April 25, 2024",
                        TimeToCook="30 minute",
                        Description="1)boil your water 2)add favorite pasta to boiling water 3)bake chicken 4)add alfredo sauce to a saucepan 5)remove chicken from oven and cut into strips 6) drain pasta 7)combine pasta with sauce and chicken for flare you can add some parmesian cheese 8)Enjoy your meal!",
                        Author="Paige W"
                    },
                    new Recipe
                    {
                        RecipeId = "10",
                        Title = "BBQ Pork chops",
                        DateAdded="April 24, 2024",
                        TimeToCook="30 minutes",
                        Description="1)turn on gas bbq pit 2)season pork chops with salt pepper garlic and onion powder 3)put pork chops onto the grill 4)bask your pork chops with bbq sauce 5)remove and turn off grill 6)Enjoy your meal!",
                        Author="Paige W"
                    },
                    new Recipe 
                    {
                        RecipeId = "11",
                        Title = "Slow Cooker Sloppy Joes",
                        DateAdded="April 25,2024",
                        TimeToCook="1) add beef, garlic, chili powder, onion powder, dry mustard, salt and pepper to the crockpot 2)mix the ingredients together 3)set on high and cook for 4 hours 4)enjoy your meal!",
                        Description="4 hours",
                        Author="Paige W"
                    },
                      new Recipe 
                    {
                        RecipeId = "12",
                        Title = "Nachos",
                        DateAdded="April 25, 2024",
                        TimeToCook="30 minutes",
                        Description="1) brown ground beef on medium heat with seasoning, salt and pepper with fresh onion and garlic 2) drain oil from the beef 3)set asside 4) can of refried beans and heat in a pan until bubbly 5) take off heat  6) heat nacho cheese sauce 7)combine chips, beans, meat and cheese 7)add any aditional toppings like lettuce, sour cream, jalepenos 8)enjoy your meal! ",
                        Author="Paige W"
                    },
                      new Recipe 
                    {
                        RecipeId = "13",
                        Title = "Chili Dogs",
                        DateAdded="April 25, 2024",
                        TimeToCook="30 minutes",
                        Description="1) lightly score hot dogs 2)lightly oil pan on medium heat cooking hot dogs on all sides 3)cook chili till bubbly 4)heat hot dog buns in microwave for 30 seconds 5)combine hot dog buns, hot dog, and chili 6)add your favorite topings 7)enjoy!",
                        Author="Paige W"
                    },
                      new Recipe 
                    {
                        RecipeId = "14",
                        Title = "Chicken Tenders",
                        DateAdded="April 25,2024",
                        TimeToCook="30 minutes",
                        Description="1) take chicken breast 2)tenderize and cut chicken into strips against the grain 3)make your prefered batter 4)put chicken strips into batter till coated 5)fry chicken stips in a pan of oil 6)enjoy!",
                        Author="Paige W"
                    },
                      new Recipe 
                    {
                        RecipeId = "15",
                        Title = "Grilled Ham and Cheese",
                        DateAdded="April 25, 2024",
                        TimeToCook="15 minutes",
                        Description="1)lightly butter the bread 2)cook both sides of the bread 3)add cheese and ham to the bread slices 4)put bread together 5)enjoy!",
                        Author="Paige W"
                    },
                      new Recipe 
                    {
                        RecipeId = "16",
                        Title = "Omlet",
                        DateAdded="April 24, 2024",
                        TimeToCook="20 minutes",
                        Description="1) in a bowl combine 3 eggs seasoned with salt and milk 2)whisk until combined 3)chop onions and ham 4)lightly butter pan 5)put egg mixture and 1/4 of ingredients into the mixture 6)flip and add half of the ingredients and cheese into the middle of the omletthen fold 7)cook and top the rest of the ingredients onto the folded omlet 8)enjoy!",
                        Author="Paige W"
                    },
                      new Recipe 
                    {
                        RecipeId = "17",
                        Title = "Hamburgers",
                        DateAdded="April 25, 2024",
                        TimeToCook="45 minutes",
                        Description="1)season ground beef with seasoning, salt and pepper 2)chop onions and garlic finely 3)mix into the hamburger meat 4)roll and shape small hamburger meat balls 6)put meat onto a pan and smash them down 7)toast bun on the pan 8)combine meat and bun then add your toppings 9)enjoy!",
                        Author="Paige W"
                    },
                      new Recipe 
                    {
                        RecipeId = "18",
                        Title = "Breakfast Sandwhich",
                        DateAdded="April 25,2024",
                        TimeToCook="30 minutes",
                        Description="1)Cook bacon, and eggs 2)take bread of choice 3)combine bacon,eggs,cheese and bread 4)enjoy! ",
                        Author="Paige W"
                    },
                      new Recipe 
                    {
                        RecipeId = "19",
                        Title = "Blueberry Muffins",
                        DateAdded="April 25, 2024",
                        TimeToCook="30 minutes",
                        Description="1)combine milk, eggs and oil with muffin mix 2)bake in the oven until golden brown 3)enjoy!",
                        Author="Paige W"
                    },
                         new Recipe 
                    {
                        RecipeId = "20",
                        Title = "Banana Pancakes",
                        DateAdded="April 25, 2024",
                        TimeToCook="30 minutes",
                        Description="1)combine ingredients with pancake box 2)chop banana slices and add to batter 3)cook on low heat till bubbly then flip 4)enjoy!",
                        Author="Paige W"
                    }
                );
            }

            using (var context = new UserContext(
                serviceProvider.GetRequiredService<DbContextOptions<UserContext>>()))
            {
                
                if (context.Users.Any())
                {
                    return; 
                }
                
                context.Users.AddRange(
                    new User
                    {
                      UserId ="1",
                        FirstName="Paige",
                        LastName="W",
                        Email="pmwinnett1@buffs.wtamu.edu"
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}