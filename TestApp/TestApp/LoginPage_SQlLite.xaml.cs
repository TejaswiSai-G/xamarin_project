using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace TestApp
{
    public partial class LoginPage_SQlLite : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<UserInfo> _userInfo;
        public LoginPage_SQlLite()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            checkDB();
        }

        protected async void checkDB()
        {
            if (await _connection.Table<UserInfo>().CountAsync() == 0)
            {
                var userInfo = new UserInfo();
                userInfo.username = "user1";
                userInfo.password = "user";
                await _connection.InsertAsync(userInfo);
            }
        }

        public bool LoginValidate(string userValue, string passValue)
        {
            var userInfo = _connection.Table<UserInfo>().Where(i => i.username == userValue && i.password == passValue).FirstOrDefaultAsync();
            if (userInfo.Result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        async public void LoginButton_Clicked(object sender, EventArgs e)
        {
            var validData = LoginValidate(user.Text, pass.Text);
            if (validData)
            {
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                await DisplayAlert("Login", "Entered username or passowrd are incorrect, Try Again!", "OK");
            }
        }

        async public void RegisterButton_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }
        async public void ShowList_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SQliteDemo());
        }
    }
}
