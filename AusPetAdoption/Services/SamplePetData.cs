using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AusPetAdoption.Models;
namespace AusPetAdoption.Services
{
    public static class SamplePetData
    {
        static Random random = new Random();
        static T Random<T>(this IList<T> This) => This[random.Next(This.Count)];
        static bool FlipCoin() => random.Next(1) == 0;

        public static IList<Pet> Pets { get; private set; }


        //credit: https://en.wikipedia.org/wiki/List_of_dog_breeds
        static SamplePetData()
        {
            Pets = new List<Pet>();

            Pets.Add(new Pet
            {
                PostTitle = "",
                Description = "",
                Breed = "",
                ImageUrl = "",
                DateOfBirth = DateTime.UtcNow.AddDays( - new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "",
                Description = "",
                Breed = "",
                ImageUrl = "",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "",
                Description = "",
                Breed = "",
                ImageUrl = "",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "",
                Description = "",
                Breed = "",
                ImageUrl = "",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "",
                Description = "",
                Breed = "",
                ImageUrl = "",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "",
                Description = "",
                Breed = "",
                ImageUrl = "",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "",
                Description = "",
                Breed = "",
                ImageUrl = "",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "",
                Description = "",
                Breed = "",
                ImageUrl = "",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "",
                Description = "",
                Breed = "",
                ImageUrl = "",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "",
                Description = "",
                Breed = "",
                ImageUrl = "",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });



        }




        static string[] sizes = new string[]
        {
            "Extra Small", "Small", "Medium", "Large", "Extra Large"
        };
    }
}

