using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPage2 : Grid
    {
        public static readonly BindableProperty TitleTextProperty = BindableProperty.Create(nameof(TitleText),
            typeof(string),
            typeof(MyPage2),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: TitleTextPropertyChanged);

        private static void TitleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MyPage2)bindable;
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

        public static readonly BindableProperty DescriptionTextProperty = BindableProperty.Create(nameof(TitleText),
            typeof(string),
            typeof(MyPage2),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: DescriptionTextPropertyChanged);

        private static void DescriptionTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MyPage2)bindable;
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

        //public MyPage2()
        //{
        //    InitializeComponent();
        //}
    }
}
