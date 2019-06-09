using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Text;
using AusPetAdoption.Controls;
using AusPetAdoption.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(PickerWB), typeof(PickerWBRenderer))]
namespace AusPetAdoption.Droid.Renderers
{
    public class PickerWBRenderer : PickerRenderer
    {
        public PickerWBRenderer(Context context)
        : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);

        }
    }
}
