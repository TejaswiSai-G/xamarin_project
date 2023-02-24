using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async public void RegisterButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if(check.IsChecked == true)
            {
                if (fname != null && email.Text != null && pass!=null && cpass!=null )
                {
                    bool rslt = await DisplayAlert("Message", "Do You want to Register?", "YES", "NO");
                    if (rslt == true)
                    {
                        await Navigation.PopAsync();
                    }
                }
                else
                {
                    await DisplayAlert("Alert", "Enter all mandatory feilds", "OK");
                }
            }
            else
            {
                await DisplayAlert("Alert", "Plesae check the box to confrim registration", "OK");
            }
        }
    }
}
