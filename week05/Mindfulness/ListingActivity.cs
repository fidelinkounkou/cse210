using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt peace or inspiration this month?",
            "Who are some of your personal heroes?"
        };

        private List<string> _unusedPrompts;

        public ListingActivity() : base("Listing Activity", 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _unusedPrompts = new List<string>(_prompts);
        }

        public void Run()
        {
            DisplayStartingMessage();

            if (_unusedPrompts.Count == 0) _unusedPrompts = new List<string>(_prompts);
            Random rand = new Random();
            int index = rand.Next(_unusedPrompts.Count);
            string prompt = _unusedPrompts[index];
            _unusedPrompts.RemoveAt(index);

            Console.WriteLine("List as many items as you can according to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();

            List<string> items = new List<string>();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                
                if (Console.KeyAvailable == false && DateTime.Now >= endTime) break;
                
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    items.Add(input);
                }
            }

            Console.WriteLine($"You listed {items.Count} items!");
            DisplayEndingMessage();
        }
    }
}
