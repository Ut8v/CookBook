using System;
using System.Collections.Generic;
using Xamarin.Forms;
using CookBook.Model;
using CookBook.View;
using Xamarin.Essentials;

namespace CookBook
{
    public partial class HomePage : ContentPage
    {
        private List<RecipeDetail> _recipeDetails; // List to store all recipe details

        public HomePage()
        {
            InitializeComponent();
            LoadSampleRecipes();
            var device = DeviceInfo.DeviceType.ToString();
            var deviceModel = DeviceInfo.Model.ToString();
            DeviceInfoTxt.Text = device + " " + deviceModel;
        }
        public HomePage(bool isLoggedin, string name)
        {
            InitializeComponent();
            LoadSampleRecipes();
            LoggedinFinder(isLoggedin, name); //method to check if loggedin
            var device = DeviceInfo.DeviceType.ToString();
            var deviceModel = DeviceInfo.Model.ToString();
            DeviceInfoTxt.Text = device + " " + deviceModel;

        }

        public void LoggedinFinder(bool isloggedin, string name)
        {
            name = name.ToUpper();
            if (isloggedin)
            {
                LoggedInTxt.Text = "Hello! " + name;

            }
        }

        private void LoadSampleRecipes()
        {
            // Retrieve all recipes from the RecipeManager
            _recipeDetails = RecipeManager.GetAllRecipes();

            // Set the list of recipes as the ItemsSource for the ListView
            RecipesListView.ItemsSource = _recipeDetails;
        }

        // Method to handle item selection in the ListView
        async void OnRecipeSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            // Navigate to the RecipePage and pass the selected recipe details as a parameter
            var selectedRecipe = e.SelectedItem as RecipeDetail;

            // Create a new instance of the RecipePage and set its BindingContext to the selected recipe
            var recipePage = new RecipePage();
            recipePage.BindingContext = selectedRecipe;
            await Navigation.PushAsync(recipePage);

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
                    await Navigation.PushAsync(new HomePage());
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
