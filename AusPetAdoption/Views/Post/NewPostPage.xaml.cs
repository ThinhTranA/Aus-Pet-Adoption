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

            LoadPetTypePicker();
            LoadPetSizePicker();

        }

        private void LoadPetTypePicker()
        {
            var petTypeList = new List<string>();
            petTypeList.Add("Dog");
            petTypeList.Add("Cat");
            petTypeList.Add("Farm Animals");
            petTypeList.Add("Reptile");
            petTypeList.Add("Weasel & Rodents");
            petTypeList.Add("Birds & Fowls");

            petTypePicker.Title = "Select the pet type...";
            petTypePicker.ItemsSource = petTypeList;
        }

        void LoadPetSizePicker()
        {
            var petSizeList = new List<string>();
            petSizeList.Add("Extra Small");
            petSizeList.Add("Small");
            petSizeList.Add("Medium");
            petSizeList.Add("Large");
            petSizeList.Add("Extra Large");

            petSizePicker.Title = "Select the pet size...";
            petSizePicker.ItemsSource = petSizeList;

        }

    }
}
