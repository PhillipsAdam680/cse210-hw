// For my creative addition I have add 10 random prompts to the inital 5 prompts on PromptGenerator.cs.
//I added them to give more variety and deep conversation with the user.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Journal Entry Menu");
            Console.WriteLine("1. Write a entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Load a file");
            Console.WriteLine("4. Save a file");
            Console.WriteLine("5. Quit journal program");

            Console.Write("Choose an option (Enter any listed number): ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }
        }
    }
}