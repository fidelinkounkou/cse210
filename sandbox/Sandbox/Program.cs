using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        String last = Console.ReadLine();

        Console.WriteLine($"your name is {last}, {first} {last}.");
    }
}