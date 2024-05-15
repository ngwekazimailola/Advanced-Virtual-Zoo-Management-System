using System;

namespace VirtualZooManagementSystem
{
    // Enums
    public enum AnimalType
    {
        Mammal,
        Bird,
        Reptile,
        Amphibian,
        Fish
    }

    public enum FoodType
    {
        Meat,
        Grass,
        Fish,
        Fruits,
        Plants
    }

    public enum HabitatType
    {
        Desert,
        Savanna,
        Aquatic,
        Madagascar,
        Antarctic
    }

    // Struct for dietary information
    public struct DietInfo
    {
        public string? DietaryRequirements;
        public string? FeedingSchedule;
    }

    public static class AnimalTypeInformation
    {
        public static string GetAnimalTypeDescription(AnimalType type)
        {
            switch (type)
            {
                case AnimalType.Mammal:
                    return "Mammal";
                case AnimalType.Bird:
                    return "Bird";
                case AnimalType.Reptile:
                    return "Reptile";
                case AnimalType.Amphibian:
                    return "Amphibian";
                case AnimalType.Fish:
                    return "Fish";
                default:
                    return "Unknown";
            }
        }
    }

    public static class FoodTypeInformation
    {
        public static string GetFoodTypeDescription(FoodType type)
        {
            switch (type)
            {
                case FoodType.Meat:
                    return "Meat";
                case FoodType.Grass:
                    return "Grass";
                case FoodType.Fish:
                    return "Fish";
                case FoodType.Fruits:
                    return "Fruits";
                case FoodType.Plants:
                    return "Plants";
                default:
                    return "Unknown";
            }
        }
    }

    public static class HabitatTypeInformation
    {
        public static string GetHabitatTypeDescription(HabitatType type)
        {
            switch (type)
            {
                case HabitatType.Desert:
                    return "Desert";
                case HabitatType.Savanna:
                    return "Savanna";
                case HabitatType.Aquatic:
                    return "Aquatic";
                    case HabitatType.Madagascar:
                    return "Madagascar";
                case HabitatType.Antarctic:
                    return "Antarctic";
                default:
                    return "Unknown";
            }
        }
    }

    // Abstract class for Animal
    public abstract class Animal
    {
        // Private fields
        private string? name;
        private int age;
        private FoodType foodType;
        private AnimalType animalType;
        private HabitatType habitatType;
        private DietInfo dietInfo;

        // Properties for encapsulation
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public FoodType FoodType
        {
            get { return foodType; }
            set { foodType = value; }
        }

        public AnimalType AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }

        public HabitatType HabitatType
        {
            get { return habitatType; }
            set { habitatType = value; }
        }

        public DietInfo DietInfo
        {
            get { return dietInfo; }
            set { dietInfo = value; }
        }

        // Abstract methods
        public abstract void Eat();
        public abstract void Move();
        public abstract void Speak();
    }

    // Interface to move animals
    public interface IMovable
    {
        void Move();
    }

    // Interface to make animals speak
    public interface ISpeakable
    {
        void Speak();
    }

    // Interface to feed animals
    public interface IFeedable
    {
        void Feed();
    }

    public class Lion : Animal, IMovable, IFeedable ,ISpeakable
    {
        public override void Eat()
        {
            if (FoodType == FoodType.Meat)
            {
                Console.WriteLine($"The lion named {Name} is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The lion named {Name} cannot eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the lion performs for the audience.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the lion roars loudly.");
        }

        public void Feed()
        {
            if (FoodType == FoodType.Meat)
            {
                Console.WriteLine($"The lion named {Name} is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The lion named {Name} does not eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }
    }

    public class Zebra : Animal, IMovable, IFeedable ,ISpeakable
    {
        public override void Eat()
        {
            if (FoodType == FoodType.Grass)
            {
                Console.WriteLine($"{Name} the zebra is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The zebra named {Name} cannot eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the zebra crazily runs around.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the zebra sings a circus song in a neighing sound.");
        }

        public void Feed()
        {
            if (FoodType == FoodType.Grass)
            {
                Console.WriteLine($"The zebra named {Name} is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The zebra named {Name} does not eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }
    }

    public class Giraffe : Animal, IMovable, IFeedable ,ISpeakable
    {
        public override void Eat()
        {
            if (FoodType == FoodType.Plants)
            {
                Console.WriteLine($"{Name} the giraffe is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The giraffe named {Name} cannot eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the giraffe hides anxiously.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the giraffe cries out loud anxiously.");
        }

        public void Feed()
        {
            if (FoodType == FoodType.Plants)
            {
                Console.WriteLine($"The giraffe named {Name} is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The giraffe named {Name} does not eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }

    }

    public class Hippo : Animal, IMovable, IFeedable ,ISpeakable
    {
        public override void Eat()
        {
            if (FoodType == FoodType.Plants)
            {
                Console.WriteLine($"{Name} the hippo is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The hippo named {Name} cannot eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the hippo plays in the water.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the hippo grunts softly.");
        }

        public void Feed()
        {
            if (FoodType == FoodType.Plants)
            {
                Console.WriteLine($"The hippo named {Name} is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The hippo named {Name} does not eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }

        public void Swim()
        {
            Console.WriteLine($"{Name} the hippo is swimming in the water.");
        }
    }

    public class Lemur : Animal, IMovable, IFeedable ,ISpeakable
    {
        public override void Eat()
        {
            if (FoodType == FoodType.Fruits)
            {
                Console.WriteLine($"{Name} the lemur is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The lemur named {Name} cannot eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the lemur  dances to 'I Like To Move It'..");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the lemur makes loud noises.");
        }

        public void Feed()
        {
            if (FoodType == FoodType.Fruits)
            {
                Console.WriteLine($"The lemur named {Name} is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The lemur named {Name} does not eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }
    }

    public class Penguin : Animal, IMovable, IFeedable ,ISpeakable
    {
        public override void Eat()
        {
            if (FoodType == FoodType.Fish)
            {
                Console.WriteLine($"{Name} the penguin is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The penguin named {Name} cannot eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the penguin smiles and waves at the crowd.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the penguin makes cute honking sounds.");
        }

        public void Feed()
        {
            if (FoodType == FoodType.Fish)
            {
                Console.WriteLine($"The penguin named {Name} is eating {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
            else
            {
                Console.WriteLine($"The penguin named {Name} does not eat {FoodTypeInformation.GetFoodTypeDescription(FoodType)}.");
            }
        }

    }
}