
using Xamarin.Forms;

using AusPetAdoption.Controls;
using AusPetAdoption.iOS.Renderers;
using Xamarin.Forms.Platform.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(EntryWithoutBorder), typeof(EntryWithoutBorderRenderer))]
namespace AusPetAdoption.iOS.Renderers
{
    public class EntryWithoutBorderRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
                Control.BorderStyle = UITextBorderStyle.None;

        }
    }
}
