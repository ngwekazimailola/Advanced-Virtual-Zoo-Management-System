using System;
using System.Collections.Generic;

namespace VirtualZooManagementSystem
{
    // Virtual Zoo class
    public class VirtualZoo
    {
        private List<Animal> animals;

        public List<Animal> Animals { get => animals; }

        // Constructor to initialize the virtual zoo
        public VirtualZoo()
        {
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void FeedAll(FoodType food)
        {
            foreach (var animal in animals)
            {
                if (animal is IFeedable feedable)
                {
                    animal.FoodType = food;
                    feedable.Feed();
                }
            }
        }

        public void MoveAll()
        {
            foreach (var animal in animals)
            {
                if (animal is IMovable movable)
                {
                    movable.Move();
                }
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        public void SpeakAll()
        {
            foreach (var animal in animals)
            {
                if (animal is ISpeakable speakable)
                {
                    speakable.Speak();
                }
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        public void DisplayAllInfo()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name} | Age: {animal.Age} | Animal Type: {AnimalTypeInformation.GetAnimalTypeDescription(animal.AnimalType)} | Habitat Type: {HabitatTypeInformation.GetHabitatTypeDescription(animal.HabitatType)} | Food Type: {FoodTypeInformation.GetFoodTypeDescription(animal.FoodType)} | Dietary Requirements: {animal.DietInfo.DietaryRequirements} | Feeding Schedule: {animal.DietInfo.FeedingSchedule}");
            }
        }

        public void WeatherChange()
        {
            // Choosing random weather
            Random random = new Random();
            int weatherCode = random.Next(1, 4);

            string weather = "";
            switch (weatherCode)
            {
                case 1:
                    weather = "Rainy";
                    break;
                case 2:
                    weather = "Sunny";
                    break;
                case 3:
                    weather = "Snowy";
                    break;
            }

            Console.WriteLine($"Weather changes: {weather} day!");

            // How Animals behave in different weather conditions
            foreach (var animal in animals)
            {
                if (weather == "Rainy")
                {
                    if (animal is Lion || animal is Zebra || animal is Giraffe)
                    {
                        Console.WriteLine($"{animal.Name} seeks shelter from the rain.");
                    }
                    else
                    {
                        Console.WriteLine($"{animal.Name} enjoys the rain.");
                    }
                }
                else if (weather == "Sunny")
                {
                    Console.WriteLine($"{animal.Name} plays and basks in the sunshine.");
                }
                else if (weather == "Snowy")
                {
                    Console.WriteLine($"{animal.Name} hides from the heavy snow.");
                }
            }
        }

        // Method to get animal type description
        public static string GetAnimalTypeDescription(AnimalType type)
        {
            return AnimalTypeInformation.GetAnimalTypeDescription(type);
        }

        // Method to get food type description
        public static string GetFoodTypeDescription(FoodType type)
        {
            return FoodTypeInformation.GetFoodTypeDescription(type);
        }

        // Method to get habitat type description
        public static string GetHabitatTypeDescription(HabitatType type)
        {
            return HabitatTypeInformation.GetHabitatTypeDescription(type);
        }
    }
}
