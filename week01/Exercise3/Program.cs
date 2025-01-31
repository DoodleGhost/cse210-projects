using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        //Inititalize a random number
        int magicNumber = randomGenerator.Next(1, 100);
        //Ask the user for a guess and Create a loopp to keep asking the user until they get the correct number
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.WriteLine("What is the magic number? ");
            string guesstextinput = Console.ReadLine();
            guess = int.Parse(guesstextinput);
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        //Congratulate the user on the correct guess
        



    }
}