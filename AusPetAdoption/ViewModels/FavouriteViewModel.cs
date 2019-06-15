using System;
using System.Collections.ObjectModel;
using AusPetAdoption.DataObjects;
using AusPetAdoption.Services;

namespace AusPetAdoption.ViewModels
{
    public class FavouriteViewModel : BaseViewModel
    {
        public ObservableCollection<Pet> PetList { get; set; }

        public FavouriteViewModel()
        {
            PetList = new ObservableCollection<Pet>(SamplePetData.Pets);
        }
    }
}
