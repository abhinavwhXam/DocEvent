using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Doctors.Models;
using Doctors.Views;
using Doctors.ViewModels;

namespace Doctors.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            DashBoaardViewModels _DashBoaardViewModels = new DashBoaardViewModels();
            this.BindingContext = _DashBoaardViewModels;
        }

      
        protected override void OnAppearing()
        {
            base.OnAppearing();

           // if (viewModel.Items.Count == 0)
               // viewModel.IsBusy = true;
        }
    }
}