using System;

namespace VirtualZooManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a virtual zoo
            VirtualZoo zoo = new VirtualZoo();

            // Add some animals to the zoo initially
            zoo.AddAnimal(new Lion { Name = "Alex", Age = 3, FoodType = FoodType.Meat, AnimalType = AnimalType.Mammal, HabitatType = HabitatType.Savanna, DietInfo = new DietInfo { DietaryRequirements = "High protein diet", FeedingSchedule = "Twice a day" } });
            zoo.AddAnimal(new Zebra { Name = "Marty", Age = 3, FoodType = FoodType.Grass, AnimalType = AnimalType.Mammal, HabitatType = HabitatType.Savanna, DietInfo = new DietInfo { DietaryRequirements = "High fiber diet", FeedingSchedule = "Several times a day" } });
            zoo.AddAnimal(new Giraffe { Name = "Melman", Age = 4, FoodType = FoodType.Plants, AnimalType = AnimalType.Mammal, HabitatType = HabitatType.Savanna, DietInfo = new DietInfo { DietaryRequirements = "Leafy greens", FeedingSchedule = "Daily" } });
            zoo.AddAnimal(new Hippo { Name = "Gloria", Age = 5, FoodType = FoodType.Plants, AnimalType = AnimalType.Mammal, HabitatType = HabitatType.Aquatic, DietInfo = new DietInfo { DietaryRequirements = "Aquatic plants", FeedingSchedule = "Regularly" } });
            zoo.AddAnimal(new Lemur { Name = "King Julian", Age = 4, FoodType = FoodType.Fruits, AnimalType = AnimalType.Mammal, HabitatType = HabitatType.Madagascar, DietInfo = new DietInfo { DietaryRequirements = "Fruits and insects", FeedingSchedule = "Multiple times a day" } });
            zoo.AddAnimal(new Lemur { Name = "Maurice", Age = 3, FoodType = FoodType.Fruits, AnimalType = AnimalType.Mammal, HabitatType = HabitatType.Madagascar, DietInfo = new DietInfo { DietaryRequirements = "Fruits and insects", FeedingSchedule = "Multiple times a day" } });
            zoo.AddAnimal(new Lemur { Name = "Mort", Age = 2, FoodType = FoodType.Fruits, AnimalType = AnimalType.Mammal, HabitatType = HabitatType.Madagascar, DietInfo = new DietInfo { DietaryRequirements = "Fruits and insects", FeedingSchedule = "Multiple times a day" } });
            zoo.AddAnimal(new Penguin { Name = "Skipper", Age = 6, FoodType = FoodType.Fish, AnimalType = AnimalType.Bird, HabitatType = HabitatType.Antarctic, DietInfo = new DietInfo { DietaryRequirements = "Fish", FeedingSchedule = "Regularly" } });
            zoo.AddAnimal(new Penguin { Name = "Kowalski", Age = 5, FoodType = FoodType.Fish, AnimalType = AnimalType.Bird, HabitatType = HabitatType.Antarctic, DietInfo = new DietInfo { DietaryRequirements = "Fish", FeedingSchedule = "Regularly" } });
            zoo.AddAnimal(new Penguin { Name = "Rico", Age = 4, FoodType = FoodType.Fish, AnimalType = AnimalType.Bird, HabitatType = HabitatType.Antarctic, DietInfo = new DietInfo { DietaryRequirements = "Fish", FeedingSchedule = "Regularly" } });
            zoo.AddAnimal(new Penguin { Name = "Private", Age = 3, FoodType = FoodType.Fish, AnimalType = AnimalType.Bird, HabitatType = HabitatType.Antarctic, DietInfo = new DietInfo { DietaryRequirements = "Fish", FeedingSchedule = "Regularly" } });

            // Main menu For Virtual Zoo
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("************************************************");
                Console.WriteLine("*         Welcome to the Virtual Zoo           *");
                Console.WriteLine("*            Management System!                *");
                Console.WriteLine("*----------------------------------------------*");
                Console.WriteLine("* 1. Add an animal                             *");
                Console.WriteLine("* 2. Feed animals                              *");
                Console.WriteLine("* 3. Move animals                              *");
                Console.WriteLine("* 4. Make animals speak                        *");
                Console.WriteLine("* 5. Display all animal information            *");
                Console.WriteLine("* 6. Weather Change                            *");
                Console.WriteLine("* 7. Exit                                      *");
                Console.WriteLine("* 8. Diet Information                          *");
                Console.WriteLine("* Select an option:                            *");
                Console.WriteLine("************************************************");

                // Read user input
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddAnimalToZoo(zoo);
                        break;
                    case "2":
                        Console.Write("Enter the type of food options = Meat, Grass, Fish, Fruits, Plants:  ");
                        string? food = Console.ReadLine();
                        zoo.FeedAll((FoodType)Enum.Parse(typeof(FoodType), food, true));
                        break;
                    case "3":
                        zoo.MoveAll();
                        break;
                    case "4":
                        zoo.SpeakAll();
                        break;
                    case "5":
                        zoo.DisplayAllInfo();
                        break;
                    case "6":
                        zoo.WeatherChange();
                        break;
                    case "7":
                        exit = true;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    case "8":
                        Console.WriteLine("************************************************");
                        Console.WriteLine("*            Diet Information Menu             *");
                        Console.WriteLine("*----------------------------------------------*");
                        Console.WriteLine("* 1. Lion                                      *");
                        Console.WriteLine("* 2. Zebra                                     *");
                        Console.WriteLine("* 3. Giraffe                                   *");
                        Console.WriteLine("* 4. Hippo                                     *");
                        Console.WriteLine("* 5. Lemur                                     *");
                        Console.WriteLine("* 6. Penguin                                   *");
                        Console.WriteLine("* 7. Exit                                      *");
                        Console.WriteLine("*----------------------------------------------*");
                        Console.WriteLine("* Select an option to view diet information:    *");
                        Console.WriteLine("************************************************");

                        // Read user input for diet information
                        string? dietInput = Console.ReadLine();
                        switch (dietInput)
                        {
                            case "1":
                                DisplayDietInfo(zoo, typeof(Lion));
                                break;
                            case "2":
                                DisplayDietInfo(zoo, typeof(Zebra));
                                break;
                            case "3":
                                DisplayDietInfo(zoo, typeof(Giraffe));
                                break;
                            case "4":
                                DisplayDietInfo(zoo, typeof(Hippo));
                                break;
                            case "5":
                                DisplayDietInfo(zoo, typeof(Lemur));
                                break;
                            case "6":
                                DisplayDietInfo(zoo, typeof(Penguin));
                                break;
                            case "7":
                                break;
                            default:
                                Console.WriteLine("Invalid option!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }

        static void AddAnimalToZoo(VirtualZoo zoo)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("*             Add Animal to Zoo                *");
            Console.WriteLine("*----------------------------------------------*");
            Console.WriteLine("* 1. Lion                                      *");
            Console.WriteLine("* 2. Zebra                                     *");
            Console.WriteLine("* 3. Giraffe                                   *");
            Console.WriteLine("* 4. Hippo                                     *");
            Console.WriteLine("* 5. Lemur                                     *");
            Console.WriteLine("* 6. Penguin                                   *");
            Console.WriteLine("* 7. Back                                      *");
            Console.WriteLine("*----------------------------------------------*");
            Console.WriteLine("* Select an option to add animal to the zoo:    *");
            Console.WriteLine("************************************************");

            string? animalTypeInput = Console.ReadLine();
            switch (animalTypeInput)
            {
                case "1":
                    AddAnimalToZoo(zoo, typeof(Lion));
                    break;
                case "2":
                    AddAnimalToZoo(zoo, typeof(Zebra));
                    break;
                case "3":
                    AddAnimalToZoo(zoo, typeof(Giraffe));
                    break;
                case "4":
                    AddAnimalToZoo(zoo, typeof(Hippo));
                    break;
                case "5":
                    AddAnimalToZoo(zoo, typeof(Lemur));
                    break;
                case "6":
                    AddAnimalToZoo(zoo, typeof(Penguin));
                    break;
                case "7":
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }

static void AddAnimalToZoo(VirtualZoo zoo, Type animalType)
{
    Console.Write("Enter the name of the animal: ");
    string? name = Console.ReadLine();
    Console.Write("Enter the age of the animal: ");
    int age = int.Parse(Console.ReadLine());

    // Directly assign habitat and dietary requirements based on animal type
    string habitat;
    string dietaryRequirements;
    string feedingSchedule;

    if (animalType == typeof(Lion))
    {
        habitat = "Savanna";
        dietaryRequirements = "High protein diet";
        feedingSchedule = "Twice a day";
    }
    else if (animalType == typeof(Zebra))
    {
        habitat = "Savanna";
        dietaryRequirements = "High fiber diet";
        feedingSchedule = "Several times a day";
    }
    else if (animalType == typeof(Giraffe))
    {
        habitat = "Savanna";
        dietaryRequirements = "Leafy greens";
        feedingSchedule = "Daily";
    }
    else if (animalType == typeof(Hippo))
    {
        habitat = "Aquatic";
        dietaryRequirements = "Aquatic plants";
        feedingSchedule = "Regularly";
    }
    else if (animalType == typeof(Lemur))
    {
        habitat = "Madagascar";
        dietaryRequirements = "Fruits and insects";
        feedingSchedule = "Multiple times a day";
    }
    
    else if (animalType == typeof(Penguin))
    {
        habitat = "Antarctic";
        dietaryRequirements = "Fish";
        feedingSchedule = "Regularly";
    }
    else
    {
        Console.WriteLine("Invalid animal type!");
        return;
    }

    var animal = (Animal)Activator.CreateInstance(animalType);
    animal.Name = name;
    animal.Age = age;
    animal.HabitatType = (HabitatType)Enum.Parse(typeof(HabitatType), habitat, true);
    animal.DietInfo = new DietInfo { DietaryRequirements = dietaryRequirements, FeedingSchedule = feedingSchedule };

    zoo.AddAnimal(animal);

    Console.WriteLine($"Added {name} to the zoo!");
}

        static void DisplayDietInfo(VirtualZoo zoo, Type animalType)
        {
            if (animalType == typeof(Lion))
            {
                Console.WriteLine("Lion diet: High protein diet. Feeding schedule: Twice a day.");
            }
            else if (animalType == typeof(Zebra))
            {
                Console.WriteLine("Zebra diet: High fiber diet. Feeding schedule: Several times a day.");
            }
            else if (animalType == typeof(Giraffe))
            {
                Console.WriteLine("Giraffe diet: Leafy greens. Feeding schedule: Daily.");
            }
            else if (animalType == typeof(Hippo))
            {
                Console.WriteLine("Hippo diet: Aquatic plants. Feeding schedule: Regularly.");
            }
            else if (animalType == typeof(Lemur))
            {
                Console.WriteLine("Lemur diet: Fruits and insects. Feeding schedule: Multiple times a day.");
            }
            else if (animalType == typeof(Penguin))
            {
                Console.WriteLine("Penguin diet: Fish. Feeding schedule: Regularly.");
            }
        }
    }
}