using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class LoginPage : ContentPage
    {
        String usern = "admin";
        string passw = "123";
        public LoginPage()
        {
            InitializeComponent();
        }

        async public void LoginButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (user.Text!=null && pass.Text!=null)
            {
                if (user.Text == usern && pass.Text == passw)
                {
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    await DisplayAlert("Login", "Entered username or passowrd are incorrect", "OK");
                }
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
