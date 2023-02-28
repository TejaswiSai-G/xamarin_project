using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                string usern = Application.Current.Properties["Name"].ToString();
                label1.Text = "Welcome " + usern;
            }
        }
    }
}
