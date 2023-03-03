using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SQLite;
using Xamarin.Forms;

namespace TestApp
{
    public partial class RegisterPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        private ObservableCollection<UserInfo> _userInfo;
        public RegisterPage()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        async public void RegisterButton_Clicked(System.Object sender, System.EventArgs e)
        {
            if(check.IsChecked == true)
            {
                if (username.Text != null && pass != null && cpass != null )
                {
                    if (pass.Text == cpass.Text)
                    {
                        await _connection.CreateTableAsync<UserInfo>();
                        var user_info = await _connection.Table<UserInfo>().ToListAsync();
                        _userInfo = new ObservableCollection<UserInfo>(user_info);
                        var users = new UserInfo { username = username.Text, password = pass.Text };
                        await _connection.InsertAsync(users);
                        _userInfo.Add(users);

                        await DisplayAlert("Register", "User Got Sucuesfually added", "OK");
                    }
                    else
                    {
                        await DisplayAlert("Alert", "Password and confrim paswoord dosen't match, Try Again!", "OK");
                    }

                    //bool rslt = await DisplayAlert("Message", "Do You want to Register?", "YES", "NO");
                    //if (rslt == true)
                    //{
                    //    await Navigation.PopAsync();
                    //}
                }
                else
                {
                    await DisplayAlert("Alert", "Enter all mandatory feilds", "OK");
                }
            }
            else
            {
                await DisplayAlert("Alert", "Plesae check the box to confrim registration", "OK");
            }
        }
    }
}
