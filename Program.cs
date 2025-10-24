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
            Console.WriteLine("=== Meny med 5 Övningar ===");
            Console.WriteLine("1. Vänd Ord");
            Console.WriteLine("2. Unika Namn");
            Console.WriteLine("3. Kortaste och Längsta Ord");
            Console.WriteLine("4. Hitta Jämna Tal");
            Console.WriteLine("5. Ta Bort Korta Ord");
            Console.WriteLine("6. Avsluta");
            Console.Write("\nVälj ett alternativ: ");

            switch (Console.ReadLine())
            {
                case "1":
                    metodManager.Reverse();
                    break;
                case "2":
                    UnikaNamn();
                    break;
                case "3":
                    KortOchLångtOrd();
                    break;
                case "4":
                    JämnaTal();
                    break;
                case "5":
                    TaBortKortaOrd();
                    break;
                case "6":
                    körMeny = false;
                    Console.WriteLine("Programmet avslutas...");
                    break;
                default:
                    Console.WriteLine("Fel val, försök igen!");
                    break;
            }

            if (körMeny)
            {
                Console.WriteLine("\nTryck på valfri tangent för att återgå till menyn...");
                Console.ReadKey();
            }
        }
    }