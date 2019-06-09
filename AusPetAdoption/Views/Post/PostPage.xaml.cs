using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AusPetAdoption.Views
{
    public partial class PostPage : ContentPage
    {
        public PostPage()
        {
            InitializeComponent();
        }

        void AddPostCommand(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new NewPostPage()));
        }
    }
}
