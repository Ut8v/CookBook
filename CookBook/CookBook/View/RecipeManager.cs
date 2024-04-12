using System;
using System.Collections.Generic;
using CookBook.Model;

namespace CookBook
{
    public static class RecipeManager
    {
        private static List<RecipeDetail> _recipes;

        // Initialize the list of recipes
        static RecipeManager()
        {
            _recipes = new List<RecipeDetail>
            {
                //Spaghetti Carbonara
                new RecipeDetail
                {
                    Name = "Spaghetti Carbonara",
                    Description = "Classic Italian pasta dish with eggs, cheese, pancetta, and pepper.",
                    Ingredients = new List<string>
                    {
                        "8 ounces spaghetti",
                        "2 large eggs",
                        "1/2 cup grated Parmesan cheese",
                        "4 slices bacon or pancetta",
                        "2 cloves garlic, minced",
                        "Salt and black pepper to taste",
                        "Chopped parsley for garnish"
                    },
                    Instructions = new List<string>
                    {
                        @"1. Cook spaghetti according to package instructions.",
                        "2. In a large bowl, whisk together eggs and Parmesan cheese.",
                        "3. Cook bacon or pancetta in a skillet until crispy, then remove from skillet and chop.",
                        "4. In the same skillet, add minced garlic and cook until fragrant.",
                        "5. Add cooked spaghetti to the skillet and toss to coat with garlic.",
                        "6. Remove skillet from heat and quickly pour egg mixture over spaghetti, stirring constantly to prevent eggs from scrambling.",
                        "7. Add chopped bacon or pancetta to the skillet and toss to combine.",
                        "8. Season with salt and pepper to taste.",
                        "9. Serve immediately, garnished with chopped parsley."
                    }
                },

                //Chicken Alfredo
                new RecipeDetail
                {
                    Name = "Chicken Alfredo",
                    Description = "Creamy pasta dish with grilled chicken, garlic, and Parmesan cheese.",
                    Ingredients = new List<string>
                    {
                        "8 ounces fettuccine pasta",
                        "2 boneless, skinless chicken breasts",
                        "2 tablespoons olive oil",
                        "3 cloves garlic, minced",
                        "1 cup heavy cream",
                        "1 cup grated Parmesan cheese",
                        "Salt and black pepper to taste",
                        "Chopped parsley for garnish"
                    },
                    Instructions = new List<string>
                    {
                        @"1. Cook fettuccine pasta according to package instructions.",
                        "2. Season chicken breasts with salt and pepper.",
                        "3. Heat olive oil in a skillet over medium heat and cook chicken until browned and cooked through, about 6-8 minutes per side. Remove chicken from skillet and slice.",
                        "4. In the same skillet, add minced garlic and cook until fragrant.",
                        "5. Stir in heavy cream and grated Parmesan cheese, stirring constantly until sauce is smooth and creamy.",
                        "6. Season sauce with salt and pepper to taste.",
                        "7. Add cooked fettuccine to the skillet and toss to coat with sauce.",
                        "8. Serve pasta topped with sliced chicken, garnished with chopped parsley."
                    }
                },

                //Chocolate Chip Cookies
                new RecipeDetail
                {
                    Name = "Chocolate Chip Cookies",
                    Description = "Classic homemade cookies with chocolate chips and walnuts.",
                    Ingredients = new List<string>
                    {
                        "1 cup butter, softened",
                        "1 cup white sugar",
                        "1 cup packed brown sugar",
                        "2 eggs",
                        "2 teaspoons vanilla extract",
                        "3 cups all-purpose flour",
                        "1 teaspoon baking soda",
                        "2 teaspoons hot water",
                        "1/2 teaspoon salt",
                        "2 cups semisweet chocolate chips",
                        "1 cup chopped walnuts"
                    },
                    Instructions = new List<string>
                    {
                        "1. Preheat oven to 350 degrees F (175 degrees C).",
                        "2. Cream together the butter, white sugar, and brown sugar until smooth.",
                        "3. Beat in the eggs one at a time, then stir in the vanilla.",
                        "4. Dissolve baking soda in hot water. Add to batter along with salt.",
                        "5. Stir in flour, chocolate chips, and nuts.",
                        "6. Drop by large spoonfuls onto ungreased pans.",
                        "7. Bake for about 10 minutes in the preheated oven, or until edges are nicely browned."
                    }
                },

                //Grilled Salmon
                new RecipeDetail
                {
                    Name = "Grilled Salmon",
                    Description = "Healthy dish featuring grilled salmon fillets with lemon and herbs.",
                    Ingredients = new List<string>
                    {
                        "4 salmon fillets",
                        "1/4 cup olive oil",
                        "1/4 cup lemon juice",
                        "2 cloves garlic, minced",
                        "1 teaspoon dried basil",
                        "1 teaspoon dried oregano",
                        "Salt and black pepper to taste"
                    },
                    Instructions = new List<string>
                    {
                        "1. In a small bowl, mix together olive oil, lemon juice, garlic, basil, oregano, salt, and pepper.",
                        "2. Place salmon fillets in a shallow dish and pour marinade over salmon, turning to coat. Cover and refrigerate for at least 30 minutes.",
                        "3. Preheat grill for medium-high heat.",
                        "4. Lightly oil grill grate. Remove salmon from marinade and shake off excess.",
                        "5. Grill salmon for 6 to 8 minutes per side, or until fish flakes easily with a fork."
                    }
                },

                //Vegetable Stir-Fry
                new RecipeDetail
                {
                    Name = "Vegetable Stir-Fry",
                    Description = "Quick and easy stir-fried vegetables with soy sauce and ginger.",
                    Ingredients = new List<string>
                    {
                        "2 tablespoons vegetable oil",
                        "1 onion, thinly sliced",
                        "2 cloves garlic, minced",
                        "1 bell pepper, sliced",
                        "1 cup broccoli florets",
                        "1 cup sliced mushrooms",
                        "1 carrot, julienned",
                        "1/4 cup soy sauce",
                        "2 teaspoons cornstarch",
                        "1 teaspoon brown sugar",
                        "1 teaspoon minced fresh ginger",
                        "1/4 cup water"
                    },
                    Instructions = new List<string>
                    {
                        "1. Heat vegetable oil in a large skillet or wok over medium-high heat.",
                        "2. Add onion and garlic, and cook until softened.",
                        "3. Add bell pepper, broccoli, mushrooms, and carrot, and cook until vegetables are tender-crisp.",
                        "4. In a small bowl, mix together soy sauce, cornstarch, brown sugar, ginger, and water.",
                        "5. Pour sauce over vegetables in skillet, and stir to coat.",
                        "6. Cook until sauce has thickened and vegetables are evenly coated, about 2 minutes."
                    }
                },

                //Caesar Salad
                new RecipeDetail
                {
                    Name = "Caesar Salad",
                    Description = "Fresh salad with romaine lettuce, croutons, Parmesan cheese, and Caesar dressing.",
                    Ingredients = new List<string>
                    {
                        "1 head romaine lettuce, torn into bite-size pieces",
                        "1 cup croutons",
                        "1/2 cup grated Parmesan cheese",
                        "1/4 cup Caesar dressing",
                        "Salt and black pepper to taste"
                    },
                    Instructions = new List<string>
                    {
                        "1. In a large bowl, combine romaine lettuce, croutons, and Parmesan cheese.",
                        "2. Drizzle Caesar dressing over salad and toss to coat.",
                        "3. Season with salt and pepper to taste.",
                        "4. Serve immediately as a side dish or add grilled chicken or shrimp for a main course."
                    }
                }
            };
        }

        // Method to retrieve all recipes
        public static List<RecipeDetail> GetAllRecipes()
        {
            return _recipes;
        }

        // Method to retrieve a specific recipe by name
        public static RecipeDetail GetRecipeByName(string name)
        {
            return _recipes.Find(recipe => recipe.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
