using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class CustomMainPage : ContentPage
    {
        public string TitleText { get; set; }
        public string DescText { get; set; } 
        public CustomMainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void btn_Clicked(object sender, EventArgs e)
        {
            cntrl.TitleText = entry.Text;
            cntrl.DescriptionText = editor.Text;
        }
    }
}
