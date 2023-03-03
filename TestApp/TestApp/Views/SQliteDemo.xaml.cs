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
        //private ObservableCollection<Recipe> _recipes;
        private ObservableCollection<UserInfo> _userInfo;
        public SQliteDemo()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }
        protected override async void OnAppearing()
        {
            await _connection.CreateTableAsync<UserInfo>();
            var user_info = await _connection.Table<UserInfo>().ToListAsync();
            _userInfo = new ObservableCollection<UserInfo>(user_info);
            listView.ItemsSource = _userInfo;
            base.OnAppearing();
        }
        async void OnAdd(object sender, System.EventArgs e)
        {
            var user_info = new UserInfo { username = "Tejaswi", password = "tej123" };
            await _connection.InsertAsync(user_info);
            _userInfo.Add(user_info);
        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            var user_info = _userInfo[0];
            user_info.username += " Updated";
            user_info.password += " Updated";

            await _connection.UpdateAsync(user_info);

        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            var user_info = _userInfo[0];
            await _connection.DeleteAsync(user_info);
            _userInfo.Remove(user_info);

        }
    }
}
