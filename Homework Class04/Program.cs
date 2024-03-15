//Homework Class 4 📒
//Task 1
//Take one string from the input and print its last 5 characters.
//Task 2
//Take a sentence as input and print its words.
//Task 3
//Create a function that takes a number as input. This method should return the sum of the digits in the number.
//##Bonus Take a sentence as input and print its largest word.

//Task 1
Console.WriteLine("Enter anything you would like, i will print out the last 5 characters");
string input = Console.ReadLine();

int startIndex = input.Length >= 5 ? input.Length - 5 : 0;
string lastFiveCharacters = input.Substring(startIndex);

Console.WriteLine("The last 5 characters of the entered string are: " + lastFiveCharacters);


//Task 2
Console.WriteLine("Enter a sentence following with empty spaces between the words, i will print out the words independently.");
string input1 = Console.ReadLine();
string[] words = input1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

foreach (string word in words)
{ Console.WriteLine(word); }

//Task 3
Console.WriteLine("Input a number and i will display the sum of the digits.");
int number;
int.TryParse(Console.ReadLine(), out number);
int sumOfDigits(int number) {

    int sum = 0;

    string numberStr = number.ToString();

    foreach (char digitChar in numberStr)
    {
        // Converting the character back to an integer and adding it to the sum
        sum += (int)Char.GetNumericValue(digitChar);
    }
    return sum;
}


int sum = sumOfDigits(number);
Console.WriteLine("Sum of digits: " + sum);

//Bonus

Console.WriteLine("Enter a sentence followed by empty spaces and i will print out the largest word.");
string sentence = Console.ReadLine();

string[] wordss = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

string largestWord = "";
foreach (string word in wordss)
{
    if (word.Length > largestWord.Length)
    {
        largestWord = word;
    }
}

Console.WriteLine("Largest word in the sentence: " + largestWord);

