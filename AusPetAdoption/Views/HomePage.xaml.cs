using System;
using System.Collections.Generic;

using Xamarin.Forms;
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
    }
}
