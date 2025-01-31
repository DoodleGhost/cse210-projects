using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        //Have a user enter in numbers into a list, then have the program display the sum, average, largest number, and smallest positive number
        //Initialize a list
        List<int> numbers = new List<int>();
        //Ask the user for a number, add it to the list, and loop until the user enters 0
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number (0 to quit): ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        //compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        //find the max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}");
    }
}