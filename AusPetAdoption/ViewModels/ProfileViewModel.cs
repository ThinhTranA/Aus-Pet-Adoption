using System;

using AusPetAdoption.Models;

namespace AusPetAdoption.ViewModels
{
    public class ProfileViewModel : BaseViewModel
    {
        public User User { get; set; }

        public ProfileViewModel()
        {
        }
    }
}
