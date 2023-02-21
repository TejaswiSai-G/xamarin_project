using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TestApp
{
    public partial class MyPage1 : ContentPage
    {
        public string[] array;
        public int i=0;
        public MyPage1()
        {
            InitializeComponent();
            //if (Device.Android == TargetPlatform.Android.ToString())
            //    Padding = new Thickness(20,30,20,20);
            //else if (Device.iOS == TargetPlatform.iOS.ToString())
            //    Padding = new Thickness(20, 40, 20, 20);
            //else if (Device.WPF == TargetPlatform.Windows.ToString())
            //    Padding = new Thickness(20, 40, 20, 20);

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

        //private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    label1.Text = text1.Text;
        //}
    }
}
