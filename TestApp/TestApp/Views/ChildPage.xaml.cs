using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChildPage : ContentPage
    {
        //public event EventHandler<double> SliderValueChanged;
        public ChildPage(ContactClass contact)
        {
            InitializeComponent();
            if (contact == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                if (contact.Status == "Approved")
                {
                    this.BindingContext = contact;
                }
                else
                {
                    label.Text = "Can't Show the Details";
                }
            }
        }
        //private void silder_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    SliderValueChanged?.Invoke(this, e.NewValue);
        //}
    }
}
