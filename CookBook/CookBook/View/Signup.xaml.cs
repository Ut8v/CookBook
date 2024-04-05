﻿using CookBook.Model;
using CookBook.services;
using Xamarin.Forms;

namespace CookBook
{
    public partial class Signup : ContentPage
    {
        public Signup()
        {
            InitializeComponent();
        }

        // Navigate back to the main page when the back arrow button is clicked
        private async void OnBackButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        // Navigate to the main page when the "Sign Up" button is clicked
        private async void OnSignUpClicked(object sender, System.EventArgs e)
        {
           string Fname = FirstnameTxt.Text;
           string Lname = LastnameTxt.Text;
           string emailTxt = EmailTxt.Text;
           string passwordTxt = PasswordTxt.Text;

           IUserInfo userinfo = DependencyService.Get<IUserInfo>();

          bool isUser = await userinfo.UserExists(emailTxt, passwordTxt);

            if (isUser)
            {

            }
            else
            {
                var user = new UserDB()
                {
                    FirstName = FirstnameTxt.Text,
                    LastName = LastnameTxt.Text,
                    Email = EmailTxt.Text,
                    Password = PasswordTxt.Text,
                };

                 await userinfo.AddUser(user);
                // After sign up is successful, navigate to the main page
                await Navigation.PushAsync(new MainPage());

            }
          
        }

        // Handle selection of menu items in the dropdown menu
        private async void OnMenuItemSelected(object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            string selectedOption = (string)picker.SelectedItem;

            // Navigate to the corresponding page based on the selected option
            switch (selectedOption)
            {
                case "Home":
                    // Do nothing since we are already on the home page
                    await Navigation.PushAsync(new HomePage());
                    break;
                case "Log In/Sign Up":
                    // Navigate to the main page containing sign-in/sign-up functionality
                    await Navigation.PushAsync(new MainPage());
                    break;
                default:
                    break;
            }
        }
    }
}