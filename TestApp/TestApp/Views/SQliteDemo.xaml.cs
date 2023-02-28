using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;

namespace TestApp
{
    public partial class SQliteDemo : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipes;
        public SQliteDemo()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }
        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<Recipe>();
            var recipes = await _connection.Table<Recipe>().ToListAsync();
            _recipes = new ObservableCollection<Recipe>(recipes);
            recipesListView.ItemsSource = _recipes;
            base.OnAppearing();
        }
        async void OnAdd(object sender, System.EventArgs e)
        {
            var receipe = new Recipe { Name = "Receipe" + DateTime.Now.Ticks };
            await _connection.InsertAsync(receipe);
            _recipes.Add(receipe);
        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            var receipe = _recipes[0];
            receipe.Name += "Updated";

            await _connection.UpdateAsync(receipe);

        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            var receipe = _recipes[0];
            await _connection.DeleteAsync(receipe);
            _recipes.Remove(receipe);

        }
    }
}
