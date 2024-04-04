using CookBook.services;
using System;
using Xamarin.Forms;
using CookBook.Model;

namespace CookBook
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnSignUpClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Signup());
        }

        async void OnSignInClicked(object sender, EventArgs e)
        {
            string emailText = EmailTxt.Text;
            string pass = PasswordTxt.Text;

            IUserInfo userInfo = DependencyService.Get<IUserInfo>();

            //check if user exists
            bool isUser = await userInfo.UserExists(emailText, pass);

            Console.WriteLine(isUser);

            if(isUser)
            {
                //if user exists take them to homepage
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                Error.Text = "Account does not exists, Please Sign up";
            }
        }

        async void OnMenuItemSelected(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            string selectedOption = (string)picker.SelectedItem;

            // Navigate to the corresponding page based on the selected option
            switch (selectedOption)
            {
                case "Home":
                    await Navigation.PushAsync(new HomePage());
                    // Do nothing since we are already on the home page
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
