using Doctors.Views.Registeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Doctors.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreenPage : ContentPage
    {
        public SplashScreenPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //your code here;

            MoveTonext();


        }

        public async void MoveTonext()
        {
            await Task.Delay(4000);
            Application.Current.MainPage = new LoginPage();
        }
    }
}