using Doctors.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Doctors.Views.Registeration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel _LoginViewModel;
        public LoginPage()
        {
            InitializeComponent();
            _LoginViewModel = new LoginViewModel(Navigation);
            this.BindingContext = _LoginViewModel;
        }

        private void MyEntry_Focused(object sender, FocusEventArgs e)
        {
            NameBox.BackgroundColor = (Color)Application.Current.Resources["NavigationPrimary"];
        }

        private void MyEntry_Unfocused(object sender, FocusEventArgs e)
        {
            NameBox.BackgroundColor = Color.Gray    ;
        }

        private void Code_Focused(object sender, FocusEventArgs e)
        {
            CodeBox.BackgroundColor = (Color)Application.Current.Resources["NavigationPrimary"];

        }

        private void code_Unfocused(object sender, FocusEventArgs e)
        {
            CodeBox.BackgroundColor = Color.Gray;
        }

        private void Place_Unfoccused(object sender, FocusEventArgs e)
        {
            PlaceBox.BackgroundColor = Color.Gray;
        }

        private void Place_Focused(object sender, FocusEventArgs e)
        {
            PlaceBox.BackgroundColor = (Color)Application.Current.Resources["NavigationPrimary"];
        }

        private void Phone_Focused(object sender, FocusEventArgs e)
        {
            PhoneBox.BackgroundColor = (Color)Application.Current.Resources["NavigationPrimary"];
        }

        private void Phone_UnFocused(object sender, FocusEventArgs e)
        {
            PhoneBox.BackgroundColor = Color.Gray;
        }

        private void Email_Focussed(object sender, FocusEventArgs e)
        {
            EmailBox.BackgroundColor = (Color)Application.Current.Resources["NavigationPrimary"];
        }

        private void Email_UNfocced(object sender, FocusEventArgs e)
        {
            EmailBox.BackgroundColor = Color.Gray;
        }
    }
}