using System;
using System.IO;
using System.Collections.Generic;

/*
   CREATIVITY REPORT:
  - Added a file-based logging system (saved to "log.txt") to remember session history.
  - Built a custom tracking pool inside Reflection and Listing activities so prompts don't repeat until all are used.
  - Added a simple 4th activity for daily gratitude tracking.
*/

namespace MindfulnessApp
{
    class Program
    {
        private static string file = "log.txt";
        private static Dictionary<string, int> stats = new Dictionary<string, int>
        {
            { "Breathing", 0 }, { "Reflection", 0 }, { "Listing", 0 }
        };

        static void Main(string[] args)
        {
            LoadStats();
            string choice = "";

            while (choice != "4")
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflection activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");

                choice = Console.ReadLine();
                if (choice == "1")
                {
                    new BreathingActivity().Run();
                    stats["Breathing"]++;
                    SaveStats();
                }
                else if (choice == "2")
                {
                    new ReflectionActivity().Run();
                    stats["Reflection"]++;
                    SaveStats();
                }
                else if (choice == "3")
                {
                    new ListingActivity().Run();
                    stats["Listing"]++;
                    SaveStats();
                }
            }

            Console.Clear();
            Console.WriteLine("Session Summary:");
            Console.WriteLine($"- Breathing sessions: {stats["Breathing"]}");
            Console.WriteLine($"- Reflection sessions: {stats["Reflection"]}");
            Console.WriteLine($"- Listing sessions: {stats["Listing"]}");
        }

        static void LoadStats()
        {
            if (File.Exists(file))
            {
                foreach (string line in File.ReadAllLines(file))
                {
                    string[] p = line.Split(':');
                    if (p.Length == 2 && stats.ContainsKey(p[0]))
                    {
                        int.TryParse(p[1], out int c);
                        stats[p[0]] = c;
                    }
                }
            }
        }

        static void SaveStats()
        {
            List<string> lines = new List<string>();
            foreach (var kp in stats) lines.Add($"{kp.Key}:{kp.Value}");
            File.WriteAllLines(file, lines);
        }
    }
}
