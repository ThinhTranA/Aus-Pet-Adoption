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
                PostTitle = "Affenpinschers have a distinct appearance",
                Description = "The breed is German in origin and dates back to the seventeenth century. The name is derived from the German Affe (ape, monkey). The breed predates and is ancestral to the Griffon Bruxellois (Brussels Griffon) and Miniature Schnauzer.[1]",
                PetType = "Dog", 
                Breed = "Affenpinscher",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                DateOfBirth = DateTime.UtcNow.AddDays( - new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "Blue Monkey",
                Description = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo Rivbreed predates and is ancestral to the Griffon Bruxellois (Brussels Griffon) and Miniature Schnauzer.[1]",
                PetType = "Monkey",
                Breed = "Blue Monkey",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "Central and East Africa",
            });

            Pets.Add(new Pet
            {
                PostTitle = "hunting capabilities and good scenting ability. ",
                Description = "The Aidi (Berber for dog) is recognized as coming from North Africa (Atlas Mountains of Morocco and Algeria). The dog has never worked as a sheepdog even though the 1963 standard was published under the name Atlas Sheepdog; this was ",
                PetType = "Dog",
                Breed = "Aidi",
                ImageUrl = "https://en.wikipedia.org/wiki/Aidi#/media/File:Aidi.jpg",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "Bassets are large, short, solid and long,",
                Description = "The Basset Hound is a short-legged breed of dog in the hound family. The Basset is a scent hound that was originally bred for the purpose of hunting hare. Their sense of smell and ability to ground-scent is second only to the Bloodhound.[1]\n\nBasset Hounds are one of six recognised \"basset\"-type breeds in France. The name basset is derived from the French word bas, meaning 'low', with the attenuating suffix -et—together meaning 'rather low'. Basset Hounds are usually bicolours or tricolours of standard hound colouration.",
                PetType = "Dog",
                Breed = "Basset Hound",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "Ebony Smoke and White female Oriental shorthair\n\n",
                Description = "An Oriental bicolour is any cat of Oriental type, either long-haired or short-haired and in any pattern including colourpoint, which has white areas on it",
                PetType= "Cat",
                Breed = "Oriental bicolour",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "The Caucasian Shepherd Dogs are strongly boned, muscular",
                Description = "Caucasian Ovcharka are large dogs. The minimum height for females is 64 centimetres (25 in), with a desirable height between 67 and 70 centimetres (26 and 28 in).[1] The minimum weight for females is 45 kilograms (99 lb). The ",
                PetType = "Dog",
                Breed = "Caucasian Shepherd Dog\n",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "Cursinus have been known on Corsica since the 16th century.",
                Description = "The Cursinu, is a breed of dog originating from Corsica. It has existed on the island since the 16th century, but went into decline during the late 20th century; however it was saved and became recognized by the Société Centrale Canine. Used for a variety of working purposes, it has no specific health issues.",
                PetType = "Dog",
                Breed = "Cursinu",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "Californian rabbit",
                Description = "he Californian, also known as the California White, is a breed of domestic rabbit originally developed for the fur and meat industries by George S. West of Lynnwood, California, starting in 1923. Mr. West maintained a herd of 300 genetically pure New Zealand Whites (with no Angora genes), which he began crossing with Standard Chinchilla rabbits (for their dense coat) and Himalayan rabbits (from which the California",
                Breed = "Californian rabbit\n",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "Suphalak",
                Description = "European created breed which expresses the colorpoint Burmese gene (cb) that results in a dark points on the extremities such as the ears, feet and tail as well as a dark mask on the face.[1] A written description and pictorial of the Suphalak first appeared in ",
                PetType = "Cat",
                Breed = "Suphalak",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "Belgian Hare for free",
                Description = "The Belgian Hare is not a true hare but rather a \"fancy\" (i.e., non-utilitarian) breed of domestic rabbit that has been selectively bred to resemble the wild hare.[1] Averaging 6–9 pounds (2.7–4.1 kg), the Belgian Hare is known for its slender and wiry frame and its long and powerful legs.",
                Breed = "Belgian Hare",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                DateOfBirth = DateTime.UtcNow.AddDays(-new Random().Next(1000)),
                Size = sizes.Random(),
                Location = "",
            });

            Pets.Add(new Pet
            {
                PostTitle = "While the LaPerm gene is a simple dominant",
                Description = "The Selkirk Rex is distinct from all other Rex breeds. Unlike the Devon Rex and Cornish Rex, the hair is of normal length and not partly missing. There are longhair and shorthair varieties. ",
                PetType = "Cat",
                Breed = "Selkirk Rex",
                ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
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

