using System;

class Program
{
    static void Main(string[] args)
    {
       PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        string filename = "myFile.txt";
        string userInput = "";
        while (userInput != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                journal.AddEntry(newEntry);
            }
            else if (userInput == "2")
            {
                journal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.Write("Enter filename: ");
                filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (userInput == "4")
            {
                Console.Write("Enter filename: ");
                filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }
    }
}