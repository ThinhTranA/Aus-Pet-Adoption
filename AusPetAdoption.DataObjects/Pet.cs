using System;
namespace AusPetAdoption.DataObjects
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


		public string DescriptionSummary { get { return Description?.Length < 50 ? Description : (Description?.Substring(0, 47) + "..."); } }

		public Pet()
        {
        }
    }
}
