using Doctors.Models;
using Doctors.Views.Registeration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Doctors.ViewModels
{
   public class LoginViewModel : LoginModel
    {

        public LoginViewModel(INavigation Nav)
        {
            NAvigation = Nav;
               LoginCOmmand = new Commands.DelegateCommand(LoginCOmmand_function);
            MoveToSignIn = new Commands.DelegateCommand(MoveToSignIn_function);
        }

        private async void MoveToSignIn_function()
        {
            await NAvigation.PushModalAsync(new PasswordLoginPage());
        }

        private bool _IsBusy;
        public bool IsBusy
        {
            get { return _IsBusy; }
            set { SetProperty(ref _IsBusy, value); }
        }

        private async  void LoginCOmmand_function()
        {
            IsBusy = true;
            await Task.Delay(3000);
         await  NAvigation.PushModalAsync(new ChangePasswordpage());
           IsBusy = false;
        }
    }
}
