using System;
using AusPetAdoption.DataObjects;

namespace AusPetAdoption.ViewModels
{
    public class PostDetailViewModel : BaseViewModel
    {
        public  Pet Pet { get; private set; }

        public PostDetailViewModel( Pet pet)
        {
            Pet = pet;
        }
    }
}
