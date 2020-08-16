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
    public partial class ChangePasswordpage : ContentPage
    {
        ChangePasswordViewModel _ChangePasswordViewModel;
        public ChangePasswordpage()
        {
            InitializeComponent();
            _ChangePasswordViewModel = new ChangePasswordViewModel(Navigation);
            this.BindingContext = _ChangePasswordViewModel;
        }
    }
}