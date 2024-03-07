//Make a console application called SumOfEven. Inside it create an array of 6 integers. Find and print the sum of the even numbers from the array:

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.1:
//3
//Enter integer no.1:
//7
//Enter integer no.1:
//3
//Enter integer no.1:
//2
//Enter integer no.1:
//8
//Expected Output:
//The result is: 14


int[] ints = new int[6];

for (int i = 0; i < ints.Length; i++)
{
    Console.WriteLine("Enter integer no: " + (i+1));
    int.TryParse(Console.ReadLine(), out ints[i]);

}

int sum = 0;
foreach (int num in ints)
{
    if (num %2 == 0)
    { 
        sum += num; 
    }
}
Console.WriteLine("The result is: " + sum);