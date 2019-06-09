using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Text;
using AusPetAdoption.Controls;
using AusPetAdoption.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryWithoutBorder), typeof(EntryWithoutBorderRenderer))]
namespace AusPetAdoption.Droid.Renderers
{
    public class EntryWithoutBorderRenderer : EntryRenderer
    {
        public EntryWithoutBorderRenderer(Context context)
        : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);

        }
    }
}
