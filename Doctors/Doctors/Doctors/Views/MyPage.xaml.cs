using System;
using System.Collections.Generic;
using Doctors.ViewModels;
using Xamarin.Forms;

namespace Doctors.Views
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            DashBoaardViewModels _DashBoaardViewModels = new DashBoaardViewModels();
            this.BindingContext = _DashBoaardViewModels;
        }
    }
}
