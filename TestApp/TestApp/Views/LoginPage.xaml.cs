using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TestApp
{
    public partial class LoginPage : ContentPage
    {
        public string[] usern = { "admin", "Admin" };
        public string passw = "123";
        public LoginPage()
        {
            InitializeComponent();
        }

        async public void LoginButton_Clicked(object sender, EventArgs e)
        {
            if (user.Text!=null && pass.Text!=null)
            {
                if (user.Text == usern[1] || user.Text == usern[2] && pass.Text == passw)
                {
                    Application.Current.Properties["Name"] = user.Text;
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

        async public void ForgotButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPasswordPage());
        }

        async public void RegisterButton_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
