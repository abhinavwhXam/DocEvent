using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Doctors.Services;
using Doctors.Views;
using Doctors.Views.Registeration;

namespace Doctors
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new SplashScreenPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
