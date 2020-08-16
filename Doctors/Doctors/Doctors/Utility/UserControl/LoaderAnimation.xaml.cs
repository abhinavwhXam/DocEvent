using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Doctors.Utility.UserControl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoaderAnimation : ContentView
    {
        public LoaderAnimation()
        {
            InitializeComponent();
        }

        public LoaderAnimation(string Message)
        {
            InitializeComponent();
            Messagess.Text = Message;
        }
    }
}