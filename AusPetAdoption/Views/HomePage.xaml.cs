using System;
using System.Collections.Generic;

using Xamarin.Forms;
using AusPetAdoption.Models;
using AusPetAdoption.ViewModels;

namespace AusPetAdoption.Views
{
    public partial class HomePage : ContentPage
    {
        HomeViewModel viewModel;

        public HomePage()
        {
            InitializeComponent();
            BindingContext = this.viewModel = new HomeViewModel();
        }

        async void OnPetSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var pet = e.SelectedItem as Pet;
            if (pet == null)
                return;
            await Navigation.PushAsync(new PostDetailPage(new PostDetailViewModel(pet)), animated: true);

            PetsListView.SelectedItem = null;
        }
    }
}
