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
    public partial class PasswordLoginPage : ContentPage
    {
        PasswordLoginPageViewModel _PasswordLoginPageViewModel;
        public PasswordLoginPage()
        {
            InitializeComponent();
            _PasswordLoginPageViewModel = new PasswordLoginPageViewModel(Navigation);
            this.BindingContext = _PasswordLoginPageViewModel;
        }

        private void MyEntry_Focused(object sender, FocusEventArgs e)
        {
                
        }

        private void MyEntry_Unfocused(object sender, FocusEventArgs e)
        {

        }

        private void Place_Focused(object sender, FocusEventArgs e)
        {

        }

        private void Place_Unfoccused(object sender, FocusEventArgs e)
        {

        }
    }
}