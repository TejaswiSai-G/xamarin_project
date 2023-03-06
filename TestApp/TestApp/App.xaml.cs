using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace TestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new SearchInListView();
            //MainPage = new NavigationPage(new LoginPage_SQlLite());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
