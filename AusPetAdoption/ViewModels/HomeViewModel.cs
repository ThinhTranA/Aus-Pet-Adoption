using System;
using System.Collections.ObjectModel;

using AusPetAdoption.DataObjects;
using AusPetAdoption.Services;

namespace AusPetAdoption.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<Pet> PetList { get; set; }

        public HomeViewModel()
        {
            PetList = new ObservableCollection<Pet>(SamplePetData.Pets);
        }
    }
}
