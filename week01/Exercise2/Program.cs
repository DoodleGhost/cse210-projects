using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");
        string gradetextinput = Console.ReadLine();
        int grade = int.Parse(gradetextinput);
        string lettergrade = "";
        if (grade >= 90)
        {
            lettergrade = "A";
        }
        else if (grade >= 80)
        {
            lettergrade = "B";
        }
        else if (grade >= 70)
        {
            lettergrade = "C";
        }
        else if (grade >= 60)
        {
            lettergrade = "D";
        }
        else
        {
            lettergrade = "F";
        }
        Console.WriteLine($"Your grade is: {lettergrade}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better luck next time!");
        }

    }
}