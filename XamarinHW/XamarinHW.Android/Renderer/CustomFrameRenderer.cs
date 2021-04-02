using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;
using XamarinHW.CustomView;
using XamarinHW.Droid.Renderer;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]

namespace XamarinHW.Droid.Renderer
{
    public class CustomFrameRenderer : FrameRenderer
    {
        public CustomFrameRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            CardElevation = 50;
            if (Control != null)
            {
                Control.SetOutlineSpotShadowColor(Android.Graphics.Color.Red);
            }
        }
        
    }
}