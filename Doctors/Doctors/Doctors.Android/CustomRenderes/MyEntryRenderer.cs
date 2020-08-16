using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Doctors.Droid.CustomRenderes;
using Doctors.Utility.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace Doctors.Droid.CustomRenderes
{
    class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);

                // set the cursor color the same as the entry TextColor
                IntPtr IntPtrtextViewClass = JNIEnv.FindClass(typeof(TextView));
                IntPtr mCursorDrawableResProperty =
                       JNIEnv.GetFieldID(IntPtrtextViewClass, "mCursorDrawableRes", "I");
                // replace 0 with a Resource.Drawable.my_cursor 
                JNIEnv.SetField(Control.Handle, mCursorDrawableResProperty, 0);
            }
        }
    }
}