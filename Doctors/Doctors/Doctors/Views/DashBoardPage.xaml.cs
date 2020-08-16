using Doctors.ViewModels;
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
    public partial class DashBoardPage : ContentPage
    {
        DashBoaardViewModels _DashBoaardViewModels;
        public DashBoardPage()
        {
            InitializeComponent();
            _DashBoaardViewModels = new DashBoaardViewModels();
            this.BindingContext = _DashBoaardViewModels;
        }
    }
}