using System;

using Xamarin.Forms;

namespace AusPetAdoption.ViewModels
{
    public class NewPostViewModel : BaseViewModel
    {
        public Command CancelCommand { get; set; }

        public INavigation Navigation { get; set; }

        public NewPostViewModel()
        {

            CancelCommand = new Command(() => ExecuteCancelCommand());
        }

        private void ExecuteCancelCommand()
        {
            Navigation.PopModalAsync();
        }
    }
}
