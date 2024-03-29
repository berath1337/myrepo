//Task 1
//Give the user an option to input numbers
//After inputing each number ask them if they want to input another with a Y/N question
//Store all numbers in a QUEUE
//When the user is done adding numbers print the numbers in the order that the user entered them from the QUEUE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using Homework_Class_08;
using System.Collections;
using System.Xml.Linq;

void Main()
{
    bool success = false;
    Queue<int> myQueue = new Queue<int>();

    while (!success)
    {
        Console.WriteLine("Please input a number:");
        string input = Console.ReadLine();


        if (int.TryParse(input, out int i))
        {
            myQueue.Enqueue(i);
        }
        else
        {

            Console.WriteLine("Please enter a valid number");
        }

        Console.WriteLine("Press N if you want to stop entering numbers, or any other key to continue.");
        string decision = Console.ReadLine().ToUpper();

        if (decision == "N")
        {
            success = true;
        }
    }

    Console.WriteLine("The numbers entered are:");
    while (myQueue.Count > 0)
    {
        Console.WriteLine(myQueue.Dequeue());

    }
}

Main();

//Task 2
//Create a list of ten numbers.
//Use LINQ to select in a list of the squares of all the numbers in the list from above.


void GetSquare()
{
    Console.WriteLine("===========EVERCISE 2==============");
    List<int> numbers = new List<int>()
{1,2,3,4,5,6,7,8,9,0};

    List<int> squares = numbers.Select(x => x * x).ToList();
    Console.WriteLine($"The squares of {string.Join(", ", numbers)} are: " + string.Join(", ", squares));
    
}


//Task 3
//Create a class Animal. Each Animal has name, color, age and Gender. Use enum for Gender.
//Find the names of all the animals aged 5 or more Find all the names of the animals that start with 'A' Find all male, brown animals Find the first animal whose name is longer than 10 characters
void Animals()
{
    Console.WriteLine("===========EVERCISE 3==============");
    List<Animal> animals = new List<Animal>()
{
new Animal("Alpha", "Brown", 8, Gender.Male),
new Animal("Terminatordog", "White", 3, Gender.Female),
new Animal("Buddy", "Black", 15, Gender.Male),
new Animal("Jacky", "Yellow", 30, Gender.Female),
};

    List<Animal> animalsAged5OrMore = animals.Where(x => x.Age >= 5).ToList();

    Console.WriteLine("Animals aged 5 and above are:");
    foreach (var animal in animalsAged5OrMore)
    {
        Console.WriteLine($"Name: {animal.Name}, Color: {animal.Color}, Age: {animal.Age}, Gender: {animal.Gender}\n");
    }

    List<Animal> animalsStartingWithA = animals.Where(x => x.Name.ToUpper().StartsWith("A")).ToList();

    Console.WriteLine("Animals with name that start with A are:");
    foreach (var animal in animalsStartingWithA)
    {
        Console.WriteLine($"Name: {animal.Name}, Color: {animal.Color}, Age: {animal.Age}, Gender: {animal.Gender}\n");
    }

    List<Animal> maleBrownAnimals = animals.Where(x => x.Color.StartsWith("Brown") && x.Gender == Gender.Male).ToList();

    Console.WriteLine("Brown and Male animals are:");
    foreach (var animal in maleBrownAnimals)
    {
        Console.WriteLine($"Name: {animal.Name}, Color: {animal.Color}, Age: {animal.Age}, Gender: {animal.Gender}\n");
    }

    Animal firstAnimalNameLongerThan10char = animals.FirstOrDefault(x => x.Name.Length > 10);

    Console.WriteLine("First animal longer than 10 characters:\n" + $"Name: {firstAnimalNameLongerThan10char.Name}, Color: {firstAnimalNameLongerThan10char.Color}, Age: {firstAnimalNameLongerThan10char.Age}, Gender: {firstAnimalNameLongerThan10char.Gender}");
}

Console.WriteLine("please type next in order to see the other 2 exercises execute");
if (Console.ReadLine().ToLower() == "next")
{
    GetSquare();
    Animals();
}