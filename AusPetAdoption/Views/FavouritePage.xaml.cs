using System;
using System.Collections.Generic;

using Xamarin.Forms;

using AusPetAdoption.ViewModels;

namespace AusPetAdoption.Views
{
    public partial class FavouritePage : ContentPage
    {
        FavouriteViewModel viewModel;
        public FavouritePage()
        {
            InitializeComponent();
            BindingContext = this.viewModel = new FavouriteViewModel();
        }

        async void OnPetSelected(object sender, SelectedItemChangedEventArgs e)
        {

            PetsListView.SelectedItem = null;
        }
    }
}
