using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    public class Search
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string location { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public string checkInAndOut { get => checkIn + " - " + checkOut; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchInListView : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Search> _search;
        public SearchInListView()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnectionSearch();
            checkDB();
        }
        protected async void checkDB()
        {
            await _connection.CreateTableAsync<Search>();
            var search_info = await _connection.Table<Search>().ToListAsync();
            _search = new ObservableCollection<Search>(search_info);
            if (await _connection.Table<Search>().CountAsync() == 0)
            {
                var searchInfo = new Search();
                searchInfo.location = "Santa Monica, CA, USA";
                var cheIn = new DateTime(2023, 12, 01);
                searchInfo.checkIn = cheIn.Date;
                var cheOut = new DateTime(2016, 12, 20);
                searchInfo.checkOut = cheOut.Date;
                await _connection.InsertAsync(searchInfo);
             }
            lstView.ItemsSource = _search;
        }

        public IEnumerable<Search> GetSearches(string searchText = null)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                return _search;
            }
            else 
            {
                return _search.Where(x => x.location.StartsWith(searchText));
            }
        }

        public void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lstView.ItemsSource = GetSearches(e.NewTextValue);
        }

        public async void DeleteSearch(object se)
        {
            for (int i = 0; i < _search.Count(); i++)
            {
                if (se.Equals(_search[i]))
                {
                    var info = _search[i];
                    await _connection.DeleteAsync(info);
                    _search.Remove(info);
                }
            }
        }

        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tappedItem =(Search)e.Item;
            var rslt = await DisplayAlert("Loaction Details", "Want to delete the "+ tappedItem.location.ToString()+" record", "YES", "NO");
            if(rslt)
            {
                DeleteSearch(tappedItem);
            }
        }
    }
}
