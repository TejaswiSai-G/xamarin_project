using System;
using System.ComponentModel;
using SQLite;

namespace TestApp
{
    public class Recipe : INotifyPropertyChanged
    {
        string _name;
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name {
            get => _name;
            set {
                _name = value;
                var args = new PropertyChangedEventArgs(nameof(Name));
                PropertyChanged?.Invoke(this, args);
            }
        }
    }
}
