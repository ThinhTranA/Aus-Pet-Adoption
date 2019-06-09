using System;
using System.Collections.Generic;

using AusPetAdoption.ViewModels;

using Xamarin.Forms;

namespace AusPetAdoption.Views
{
    public partial class NewPostPage : ContentPage
    {
        NewPostViewModel viewModel;
        public NewPostPage()
        {
            InitializeComponent();
            viewModel = new NewPostViewModel();
            BindingContext = viewModel;
            viewModel.Navigation = Navigation;
        }
    }
}
