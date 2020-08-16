using Doctors.Models;
using Doctors.Views.Registeration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Doctors.ViewModels
{
  public  class ChangePasswordViewModel : ChangePasswordModel
    {
        public ChangePasswordViewModel(INavigation Nav)
        {
            Navigation = Nav;
            ChangePAssworsCommand = new Commands.DelegateCommand(ChangePAssworsCommand_Function);
        }

        private async void ChangePAssworsCommand_Function()
        {
            IsBusy = true;
            await Task.Delay(2000);
            await Navigation.PushModalAsync(new PasswordLoginPage());
        }
    }
}
