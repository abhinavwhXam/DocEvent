using System;
using Doctors.iOS.CustomRenderer;
using Doctors.Utility.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace Doctors.iOS.CustomRenderer
{
    public class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer()
        {
        }
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				// do whatever you want to the UITextField here!
				//Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
				Control.BorderStyle = UITextBorderStyle.None;
			}
		}
	}
}
