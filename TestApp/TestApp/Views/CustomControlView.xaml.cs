using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TestApp
{
    public partial class CustomControlView : ContentView
    {
        public static BindableProperty TitleTextProperty =
            BindableProperty.Create( nameof(TitleText),
                typeof(string),typeof(CustomControlView),
                defaultValue: string.Empty,
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: TitleTextPropertyChanged);

        private static void TitleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomControlView)bindable;
            control.Title.Text = newValue?.ToString();
        }

        public string TitleText
        {
            get
            {
                return base.GetValue(TitleTextProperty)?.ToString();
            }
            set
            {
                base.SetValue(TitleTextProperty, value);
            }
        }


        public static readonly BindableProperty DescriptionTextProperty = BindableProperty.Create(nameof(DescriptionText),
            typeof(string),
            typeof(CustomControlView),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: DescriptionTextPropertyChanged);

        private static void DescriptionTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (CustomControlView)bindable;
            control.Description.Text = newValue?.ToString();
        }
        public string DescriptionText
        {
            get
            {
                return base.GetValue(DescriptionTextProperty)?.ToString();
            }
            set
            {
                base.SetValue(DescriptionTextProperty, value);
            }
        }

        public CustomControlView() 
        {
            InitializeComponent();
        }

        //async void btn_Clicked(Object sender, EventArgs e)
        //{
        //    string e1 = entry.Text;
        //    string e2 = editor.Text;

        //    await DisplayAlert("Alret", e1 + " + " + e2, "OK");
        //}
    }
}
