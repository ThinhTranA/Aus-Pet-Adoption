using System;
namespace AusPetAdoption.Models
{

    public class Pet
    {
        public string PostTitle { get; set; }
        public string Description { get; set; }
        public string PetType { get; set; }
        public string Breed { get; set; }

        public string ImageUrl { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Size { get; set; }
        public string Location { get; set; }

    }
}
