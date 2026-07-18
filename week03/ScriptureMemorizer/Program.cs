//For my creative I have changed the program to allow for the user to enter the scripture they want to memorize. I changed the preset scripture to a user choice.

using System;

class Program
{
    static void Main(string[] args)
    {
    Console.Write("Enter the book: ");
    string book = Console.ReadLine();

    Console.Write("Enter the chapter: ");
    int chapter = int.Parse(Console.ReadLine());

    Console.Write("Enter the verse: ");
    int verse = int.Parse(Console.ReadLine());

    Console.Write("Enter the scripture text: ");
    string text = Console.ReadLine();

    Reference reference = new Reference(book, chapter, verse);
    Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
                break;

            Console.WriteLine();
            Console.Write("Press Enter to memorize more or type 'quit': ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }
    }
}