using System;
using System.Collections.Generic;

using Xamarin.Forms;

using AusPetAdoption.ViewModels;

namespace AusPetAdoption.Views
{
    public partial class PostDetailPage : ContentPage
    {
        PostDetailViewModel viewModel;
        public PostDetailPage( PostDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }
    }
}
