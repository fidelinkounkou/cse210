// Author: fideli nkounkou
// Creativity: I exceeded the core requirements by adding an extra field to track the user's daily emotional state (Mood). 
// This information is seamlessly encapsulated within the Entry object, outputted visually, and fully supported 
// by the customized saving/loading pipeline using the '~~' token delimiter.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        string choice = "";
        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Random random = new Random();
                int index = random.Next(prompts.Count);
                string currentPrompt = prompts[index];

                Console.WriteLine($"\nPrompt: {currentPrompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Console.Write("How is your mood today? ");
                string mood = Console.ReadLine();

                Entry newEntry = new Entry(currentPrompt, response, mood);
                myJournal.AddEntry(newEntry);
                Console.WriteLine("Entry added!\n");
            }
            else if (choice == "2")
            {
                Console.WriteLine("\n--- Journal Entries ---");
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
        }
        Console.WriteLine("Goodbye!");
    }
}
