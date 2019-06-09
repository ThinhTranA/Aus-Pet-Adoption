using Xamarin.Forms;

using AusPetAdoption.Controls;
using AusPetAdoption.iOS.Renderers;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(PickerWB), typeof(PickerWBRenderer))]
namespace AusPetAdoption.iOS.Renderers
{
    public class PickerWBRenderer : PickerRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}
