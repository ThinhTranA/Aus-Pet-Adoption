using System;

using Xamarin.Forms;
using AusPetAdoption.Views;

namespace AusPetAdoption.ViewModels
{
    public class NewPostViewModel : BaseViewModel
    {
        public Command CancelCommand { get; set; }
        public Command AddPhotoCommand { get; set; }
        public INavigation Navigation { get; set; }

        public NewPostViewModel()
        {

            CancelCommand = new Command(() => ExecuteCancelCommand());
            AddPhotoCommand = new Command(() => ExecuteAddPhotoCommand());
        }

        private void ExecuteAddPhotoCommand()
        {
            Navigation.PushAsync(new PostPhotosPage());
        }

        private void ExecuteCancelCommand()
        {
            Navigation.PopModalAsync();
        }
    }
}
