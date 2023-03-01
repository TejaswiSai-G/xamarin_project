using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Xamarin.Forms;
 
namespace TestApp
{
    public partial class MyPage1 : ContentPage
    {
        public MyPage1()
        {
            InitializeComponent();
            //if (Device.Android == TargetPlatform.Android.ToString())
            //    Padding = new Thickness(20,30,20,20);
            //else if (Device.iOS == TargetPlatform.iOS.ToString())
            //    Padding = new Thickness(20, 40, 20, 20);
            //else if (Device.WPF == TargetPlatform.Windows.ToString())
            //    Padding = new Thickness(20, 40, 20, 20);

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                title.Text = Application.Current.Properties["Name"].ToString();
            }
            if (Application.Current.Properties.ContainsKey("NotificationEnabled"))
            {
                notificationEnabled.On = (bool)Application.Current.Properties["NotificationEnabled"];
            }
        }

        private void OnChange(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = title.Text;
            Application.Current.Properties["NotificationEnabled"] = notificationEnabled.On;
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            //label1.Text = e.Value.ToString();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            //Application.Current.Properties["Name"] = t1.Text;
            //await Navigation.PushModalAsync(new MainPage());

            //result.Text = text.Text;

            //var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Email");
            //if (response != null)
            //{
            //    l1.Text = response;
            //}
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //text.Text = "";
            //result.Text = string.Empty;
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            //label1.Text = text1.Text;
        }
    }
}
