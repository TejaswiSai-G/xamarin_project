using System;
using System.ComponentModel;
using SQLite;

namespace TestApp
{
    public class UserInfo : INotifyPropertyChanged
    {
        string _username;
        string _password;
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string username
        {
            get => _username;
            set
            {
                _username = value;
                var args = new PropertyChangedEventArgs(nameof(username));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public string password
        {
            get => _password;
            set
            {
                _password = value;
                var args = new PropertyChangedEventArgs(nameof(password));
                PropertyChanged?.Invoke(this, args);
            }
        }
    }
}
