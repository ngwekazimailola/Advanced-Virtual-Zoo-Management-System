# Advanced-Virtual-Zoo-Management-System

## Description
The Virtual Zoo Management System in C# is a software application designed to oversee the management of animals within a virtual zoo environment. This system enables users to add, track, and interact with different types of animals, emphasizing concepts such as inheritance, polymorphism, method overloading, and interface implementation. Through the use of classes and interfaces, the system facilitates the organization and simulation of various animal behaviors and characteristics.

## How to Run the Application:
1. Ensure you have the .NET SDK installed on device.
2. Download the project repository from .
3. Open code folder in your IDE.
4. Run the application.

## Project Tasks:

### Task 1: Using Structs and Enums
- Structs: Define structs for lightweight data structures: DietInfo (dietary requirements and feeding 
schedules).
- Enums: Create enums to classify information like AnimalType (mammal, bird, reptile, etc.), 
FoodType (meat, vegetation, mixed), and HabitatType (desert, forest, aquatic).
### Task 2: Implementing Abstraction
- Design abstract classes or enhance existing interfaces to represent general animal behaviors, such as 
an abstract class Animal that includes abstract methods like Eat, Move, and Speak.
- Use interfaces to define cross-category capabilities, such as IClimbable, ISwimmable, or
IFlyable, depending on the type of animal.
### Task 3: Implementing Encapsulation
- Ensure all fields in classes are private and only accessible through public methods or properties.
- Use properties to control the access to class fields with specific get and set requirements.
### Task 4: Error and Exception Handling
- Implement try-catch blocks to handle potential runtime errors, such as feeding the wrong type of 
food to an animal or handling out-of-bounds errors when accessing zoo map positions.
- Use custom exceptions to signal specific errors that can occur in zoo operations, enhancing the clarity 
of error management

## Project Structure
The project consists of the following files:
- **Program.cs:** Contains the main entry point of the application and user interaction logic.
- **Animal.cs:** Defines the base `Animal` class, specific animal classes, and interfaces for feeding and movement.
- **VirtualZoo.cs:** Implements the `VirtualZoo` class responsible for managing animals within the virtual zoo.
