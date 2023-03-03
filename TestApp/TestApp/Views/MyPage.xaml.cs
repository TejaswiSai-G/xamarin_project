using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPage : ContentPage
    {
        //public string MyDesccrition { get; set; } = "Hello Some of Desc";
        //public string MyTitle { get; set; } = "Title";

        string[] clr = { "#FF0000", "#008000", "#0000FF", "#000000" };
        int i = 0;

        public MyPage()
        {
            InitializeComponent();
            //BindingContext = this;

            //Content = new Label
            //{
            //    Text = "Hello from Code!",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    TextColor = Color.Green
            //};

            //mywebView.Source = "https://www.amazon.com/";
            //var localhtml = new HtmlWebViewSource();
            //localhtml.Html = @"<html><body><h1>Loca Html redering</h1><p>This is my paragraph</p></body></html>";
            //mywebView.Source = localhtml;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(i<clr.Length) {
                Resources["backgroudColor"] = clr[i++];
            }
            else
            {
                i=0;
                Resources["backgroudColor"] = clr[i++];
            }

            //c++;
            //label.Text = "Clicked Button " + c + " times";
        }

        //void Button_UnClicked(object sender, EventArgs e)
        //{
        //    c--;
        //    if (c < 0)
        //    {
        //        c = 0;
        //        label.Text = "Clicked Button 0 times";
        //    }
        //    else
        //    {
        //        label.Text = "Clicked Button " + c + " times";
        //    }
        //}
    }
}
