using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
        {
            InitializeComponent();
        }

        async public void SendButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if (email.Text != null && email.Text!=string.Empty)
            {
                await DisplayAlert("Message", "Sent the password reset intructions sucesfully to "+email.Text, "OK");
            }
            else
            {
                await DisplayAlert("Alert", "Enter Email address", "Ok");
            }
        }
    }
}
