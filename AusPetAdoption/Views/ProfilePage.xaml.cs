using System;
using System.Collections.Generic;

using Xamarin.Forms;

using AusPetAdoption.ViewModels;

namespace AusPetAdoption.Views
{
    public partial class ProfilePage : ContentPage
    {
        ProfileViewModel viewModel;
        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = this.viewModel = new ProfileViewModel();
        }
    }
}
