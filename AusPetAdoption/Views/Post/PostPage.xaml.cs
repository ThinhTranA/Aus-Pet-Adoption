using System;
using System.Collections.Generic;

using AusPetAdoption.ViewModels;

using Xamarin.Forms;

namespace AusPetAdoption.Views
{
    public partial class PostPage : ContentPage
    {
        PostViewModel viewModel;
        public PostPage()
        {
            InitializeComponent();
            BindingContext = this.viewModel = new PostViewModel();
        }

        async void OnPetSelected(object sender, SelectedItemChangedEventArgs e)
        {

            PetsListView.SelectedItem = null;
        }

        void AddPostCommand(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new NewPostPage()));
        }
    }
}
