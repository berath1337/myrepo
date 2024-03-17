
//Task 1
//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today

//Task 2
//Create a class Dog
//Add properties: Name, breed, color
//The dog needs to have an Eat method that returns message: The dog is now eating. A Play method returning a message : The dog is now playing. and a
//ChaseTail method that returns a message: Dog is now chasing its tail.
//The user needs to create a dog object by using inputs and then choose an option to choose one of the methods mentioned above. For example, if he enters 1 to call Eat method,
//if he enters 2 to call Play, if user enters 3 to call Play

using Homework_Class_05;
void theDog()
{
    Console.WriteLine("Please enter a name for our dog");
    var nameInput = Console.ReadLine();
    Console.WriteLine("Please enter a breed for our dog");
    var breedInput = Console.ReadLine();
    Console.WriteLine("Please enter a color for our dog");
    var colorInput = Console.ReadLine();

    Dog doggy = new Dog();
    doggy.Name = nameInput;
    doggy.Breed = breedInput;
    doggy.Color = colorInput;

    Console.WriteLine("Please enter a number from 1 to 3 to make our doggy react");
    var choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine(String.Format("Our dog's name is {0} with breed type {1} and color {2}.", doggy.Name, doggy.Breed, doggy.Color));
        doggy.Eat();
    }
    else if (choice == "2")
    {
        Console.WriteLine(String.Format("Our dog's name is {0} with breed type {1} and color {2}.", doggy.Name, doggy.Breed, doggy.Color));
        doggy.Play();
    }
    else if (choice == "3")
    {
        Console.WriteLine(String.Format("Our dog's name is {0} with breed type {1} and color {2}.", doggy.Name, doggy.Breed, doggy.Color));
        doggy.ChaseTail();
    }
    else { Console.WriteLine("Please enter a valid number from one to three and try again"); }

}

theDog();
void AgeCalculator()
{
    Console.WriteLine("Please input your birthdate with the following format MM/DD/YYYY:");
    string userInput = Console.ReadLine();
    DateTime bdayDate;
    if (DateTime.TryParse(userInput, out bdayDate))
    {
        DateTime currentDate = DateTime.Now;

        int years = currentDate.Year - bdayDate.Year;
        int months = currentDate.Month - bdayDate.Month;
        int days = currentDate.Day - bdayDate.Day;

        
        if (months < 0 || (months == 0 && days < 0))
        {
            years--;
        }

        Console.WriteLine($"Your precise age is: {years} years.");
    }
    else
    {
        Console.WriteLine("Invalid date format. Please try again.");
    }
}
AgeCalculator();

