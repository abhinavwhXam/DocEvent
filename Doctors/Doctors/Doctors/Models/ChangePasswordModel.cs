using Doctors.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Doctors.Models
{
    public class ChangePasswordModel : ModelBase
    {
        private bool _IsBusy;
        public bool IsBusy
        {
            get { return _IsBusy; }
            set { SetProperty(ref _IsBusy, value); }
        }
        public DelegateCommand ChangePAssworsCommand { get; set; }
        public INavigation Navigation { get; set; }
    }
}
