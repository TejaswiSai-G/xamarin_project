using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace TestApp
{
    public class MyPageViewModel : INotifyPropertyChanged
    {
        public MyPageViewModel()
        {
            //caluclator using MVVM model
            AddCommand = new Command(() =>
            {
                Result = Entry1 + Entry2;
            });
            SubCommand = new Command(() =>
            {
                if (Entry1 >= Entry2)
                    Result = Entry1 - Entry2;
                else
                    Result = Entry2 - Entry1;
            });
            MulCommand = new Command(() =>
            {
                Result = Entry1 * Entry2;
            });
            DivCommand = new Command(() =>
            {
                Result = Entry1 / Entry2;
            });

        }

        int _entry1;
        int _entry2;
        int _result;

        public int Entry1
        {
            get => _entry1;
            set
            {
                _entry1 = value;
                var args = new PropertyChangedEventArgs(nameof(Entry1));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public int Entry2
        {
            get => _entry2;
            set
            {
                _entry2 = value;
                var args = new PropertyChangedEventArgs(nameof(Entry2));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public int Result
        {
            get => _result;
            set
            {
                _result = value;
                var args = new PropertyChangedEventArgs(nameof(Result));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command AddCommand { get; }
        public Command SubCommand { get; }
        public Command MulCommand { get; }
        public Command DivCommand { get; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

