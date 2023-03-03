using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    public class ContactClass
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public string ImageUrl { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParentPage : ContentPage
    {
        public ParentPage()
        {
            InitializeComponent();
            listView.ItemsSource = new List<ContactClass>
            {
                new ContactClass{Name="Tejaswi",Status="Approved"},
                new ContactClass{Name="Admin",Status="Approved"},
                new ContactClass{Name="User",Status="Rejected"}
            };
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contacts = e.SelectedItem as ContactClass;
            await Navigation.PushAsync(new ChildPage(contacts));
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    var page = new ChildPage();
        //    page.SliderValueChanged += Page_SliderValueChanged;
        //    Navigation.PushAsync(page);
        //}
        //private void Page_SliderValueChanged(object sender, double e)
        //{
        //    label1.Text = e.ToString();
        //}
    }
}
