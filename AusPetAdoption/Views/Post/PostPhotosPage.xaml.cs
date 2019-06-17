using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AusPetAdoption.Utils;

namespace AusPetAdoption.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PostPhotosPage : ContentPage
    {
        public PostPhotosPage()
        {
            InitializeComponent();
        }

        async void AddPhoto_Clicked(object sender, EventArgs e)
        {
            var image = await MediaPlugin.AddPhoto();
            if (image != null)
            {
                image.HeightRequest = 160;
                image.WidthRequest = 120;
            }
        }
    }
}