using Advanced_Collections;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        MetodManager metodManager = new MetodManager();
        bool körMeny = true;

        while (körMeny)
        {
            Console.Clear();
            Console.WriteLine("=== Meny with 6 alternativs ===");
            Console.WriteLine("1. Reverse words");
            Console.WriteLine("2. UniqueName");
            Console.WriteLine("3. ShortLongWords");
            Console.WriteLine("4. EvenNumbers");
            Console.WriteLine("5. RemoveShortWords");
            Console.WriteLine("6. Quit");
            Console.Write("\n Choose Option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    metodManager.Reverse();
                    break;
                case "2":
                    metodManager.UniqueName();
                    break;
                case "3":
                    metodManager.ShortLongWords();
                    break;
                case "4":
                    metodManager.EvenNumbers();
                    break;
                case "5":
                    metodManager.RemoveShortWords();
                    break;
                case "6":
                    körMeny = false;
                    Console.WriteLine("Program ends...");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            if (körMeny)
            {
                Console.WriteLine("\nTryck på valfri tangent för att återgå till menyn...");
                Console.ReadKey();
            }
        }
    }
}