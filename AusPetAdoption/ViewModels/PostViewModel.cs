using System;
using System.Collections.ObjectModel;
using AusPetAdoption.Models;
using AusPetAdoption.Services;

namespace AusPetAdoption.ViewModels
{
    public class PostViewModel : BaseViewModel
    {
        public ObservableCollection<Pet> PetList { get; set; }

        public PostViewModel()
        {
            PetList = new ObservableCollection<Pet>(SamplePetData.Pets);
        }
    }
}
