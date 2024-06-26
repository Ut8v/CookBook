﻿using CookBook.Model;
using CookBook.services;
using System.Runtime.CompilerServices;
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

        private async void OnSignInClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
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
                //if allready user navigate to homepage
                string name = await userinfo.GetFirstName(emailTxt, passwordTxt);
                await Navigation.PushAsync(new HomePage(true,name));

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
                 string name = await userinfo.GetFirstName(emailTxt, passwordTxt);
                // After sign up is successful, navigate to the Home page
                await Navigation.PushAsync(new HomePage(true,name));

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