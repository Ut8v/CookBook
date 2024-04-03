using System.Collections.Generic;
using Xamarin.Forms;
using CookBook.Models;
using CookBook.View;
using System;

namespace CookBook
{

    public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        LoadSampleRecipes(); // Call a method to load sample recipes into the ListView
    }

    private void LoadSampleRecipes()
    {
        // Creating sample recipes
        var recipesList = new List<Recipe>
        {
            new Recipe { Name = "Spaghetti Carbonara", Description = "Classic Italian pasta dish with eggs, cheese, pancetta, and pepper." },
            new Recipe { Name = "Chicken Alfredo", Description = "Creamy pasta dish with grilled chicken, garlic, and parmesan cheese." },
            new Recipe { Name = "Chocolate Chip Cookies", Description = "Classic homemade cookies with chocolate chips and walnuts." },
            new Recipe { Name = "Grilled Salmon", Description = "Healthy dish featuring grilled salmon fillets with lemon and herbs." },
            new Recipe { Name = "Vegetable Stir-Fry", Description = "Quick and easy stir-fried vegetables with soy sauce and ginger." },
            new Recipe { Name = "Caesar Salad", Description = "Fresh salad with romaine lettuce, croutons, parmesan cheese, and Caesar dressing." }
        };

        // Set the list of sample recipes as the ItemsSource for the ListView
        RecipesListView.ItemsSource = recipesList;
    }

        // Method to handle item selection in the ListView
        async void OnRecipeSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            // Navigate to the specific recipe page passing the selected recipe as parameter
            var selectedRecipe = e.SelectedItem as Recipe;
            await Navigation.PushAsync(new RecipePage());

            // Deselect item
            RecipesListView.SelectedItem = null;
        }

        // Method to handle selection of menu items in the Picker
        async void OnMenuItemSelected(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            string selectedOption = (string)picker.SelectedItem;

            // Navigate to the corresponding page based on the selected option
            switch (selectedOption)
            {
                case "Home":
                    // Do nothing since we are already on the home page
                    break;
                case "Log In/Sign Up":
                    // Navigate to the login/sign up page
                    await Navigation.PushAsync(new MainPage());
                    break;
                default:
                    break;
            }
        }
    }
}