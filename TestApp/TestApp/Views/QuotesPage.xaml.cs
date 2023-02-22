using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class QuotesPage : ContentPage
    {
        public string[] array;
        public int i = 0;

        public QuotesPage()
        {
            InitializeComponent();

            array = new string[] { "Mango", "Apple", "Pineapple", "Grapes", "Orange" };
            label2.Text = array[i].ToString();
        }

        private void Slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label1.Text = string.Format("Font Size: {0:F0}", (int)e.NewValue);
            label2.FontSize = (int)e.NewValue;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            i++;
            if (i >= array.Length)
            {
                i = 0;
            }
            label2.Text = array[i].ToString();
        }
    }
}
