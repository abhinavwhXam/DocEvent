using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Doctors.Utility.Controls
{
    public class MyEntry : Entry
    {
        public static readonly BindableProperty BorderColorProperty =
         BindableProperty.Create(nameof(BorderColor),
             typeof(Color), typeof(MyEntry), Color.Green);
        // Gets or sets BorderColor value  
        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public static readonly BindableProperty BorderWidthProperty =
        BindableProperty.Create(nameof(BorderWidth), typeof(int),
            typeof(MyEntry), Device.OnPlatform<int>(1, 2, 2));
        // Gets or sets BorderWidth value  
        public int BorderWidth
        {
            get => (int)GetValue(BorderWidthProperty);
            set => SetValue(BorderWidthProperty, value);
        }
    }
}
