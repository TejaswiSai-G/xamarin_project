using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class MyPage : ContentPage
    {
        int c = 0;
        public MyPage()
        {
            InitializeComponent();

            //Content = new Label
            //{
            //    Text = "Hello from Code!",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    TextColor = Color.Green
            //};
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            c++;
            label.Text = "Clicked Button " + c + " times";
        }

        void Button_UnClicked(object sender, EventArgs e)
        {
            c--;
            if (c < 0)
            {
                c = 0;
                label.Text = "Clicked Button 0 times";
            }
            else
            {
                label.Text = "Clicked Button " + c + " times";
            }
        }
    }
}
