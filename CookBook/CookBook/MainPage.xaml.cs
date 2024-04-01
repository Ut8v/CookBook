using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

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

        async void onSignInClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }
    }
}
