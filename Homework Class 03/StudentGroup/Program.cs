string[] studentsG1 = new string[] { "Zdravko", "Stanko", "Petko", "Brajko", "Marijan" };
string[] studentsG2 = new string[] { "Petar", "Pavle", "Kristijan", "Andrej", "Mitko" };

Console.WriteLine("Enter student group: ( there are 1 and 2 )");
string input = Console.ReadLine();

if (input == "1")
{
    Console.WriteLine($"The students in G1 are: ");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (input == "2")
{
    Console.WriteLine($"The students in G2 are ");

    foreach (string student in studentsG2)

    { 
        Console.WriteLine(student); 
    }
}
else
{
    Console.WriteLine("You have entered an invalid group");
}
