using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchInListView : ContentPage
    {
        public SearchInListView()
        {
            InitializeComponent();
            lstView.ItemsSource = GetContacs();
        }
        private IEnumerable<Contact> GetContacs(string searchText = null)
        {
            var contacs = new List<Contact>() {
            new Contact{Name="Tejaswi",Email="tejaswi@gmail.com"},
            new Contact{Name="Admin",Email="admin@gmail.com"},
            new Contact{Name="User1",Email="user1@gmail.com"},
            new Contact{Name="User2",Email="user2@gmail.com"},
        };
            if (string.IsNullOrWhiteSpace(searchText))
                return contacs;
            return contacs.Where(x => x.Name.StartsWith(searchText));
        }
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstView.ItemsSource = GetContacs(e.NewTextValue);
        }
    }
}
