using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async public void LoginButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (user.Text!=null && pass.Text!=null && user.Text!=string.Empty && pass.Text!=string.Empty)
            {
                await DisplayAlert("Login", user.Text + " has successfully logged in", "OK");
            }
            else
            {
                await DisplayAlert("Alert","Enter all details", "OK");
            }
        }

        async public void ForgotButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPasswordPage());
        }

        async public void RegisterButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
