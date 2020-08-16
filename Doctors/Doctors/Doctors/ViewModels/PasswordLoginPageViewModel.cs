using Doctors.Models;
using Doctors.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Doctors.ViewModels
{
  public  class PasswordLoginPageViewModel : PasswordLoginPageModel
    {
        private bool _IsBusy = false;
        public bool IsBusy
        {
            get { return _IsBusy; }
            set { SetProperty(ref _IsBusy, value); }
        }

        public PasswordLoginPageViewModel(INavigation nav)
        {
            LoginCOmmand = new Commands.DelegateCommand(LoginCOmmand_function);
            Navigation = nav;
        }

        private async void LoginCOmmand_function()
        {
            IsBusy = true;
            await Task.Delay(3000);
            //await Navigation.PushModalAsync(new AppShell());
            Application.Current.MainPage = new AppShell();
            IsBusy = false;
        }
    }
}
