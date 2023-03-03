using System;
using System.ComponentModel;
using SQLite;

namespace TestApp
{
    public class Post : INotifyPropertyChanged
    {
        string _title;
        string _body;
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                var args = new PropertyChangedEventArgs(nameof(Title));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public string Body
        {
            get => _body;
            set
            {
                _body = value;
                var args = new PropertyChangedEventArgs(nameof(Body));
                PropertyChanged?.Invoke(this, args);
            }
        }
    }
}
