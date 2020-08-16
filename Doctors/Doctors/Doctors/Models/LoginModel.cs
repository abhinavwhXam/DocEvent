using Doctors.Commands;
using Doctors.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Doctors.Models
{
   public class LoginModel : ModelBase
    {
        public DelegateCommand LoginCOmmand { get; set; }

        public INavigation NAvigation { get; set; }

        public DelegateCommand MoveToSignIn { get; set; }
    }
}
