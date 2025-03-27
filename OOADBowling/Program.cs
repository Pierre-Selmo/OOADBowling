using System;
using System.Collections.Generic;
using Bowling.Classes;

class Program
{
    static List<Medlem> medlemmar = new List<Medlem>();
    static void Main()
    {
        Console.WriteLine("Välkommen till LuckyStrike!");

        while (true)
        {
            Console.WriteLine("1. Registrera medlem");
            Console.WriteLine("2. Skapa match");
            Console.WriteLine("3. Avsluta");
            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    RegistreraMedlem();
                    break;
                case "2":
                    SkapaMatch();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("\nOgiltigt val, försök igen.");
                    break;
            }
        }
    }

    static void RegistreraMedlem()
    {
        Console.Write("\nAnge namn: ");
        string namn = Console.ReadLine();
        Medlem medlem = MedlemSkapare.SkapaMedlem(namn);
        medlemmar.Add(medlem);
        Console.WriteLine($"Medlem registrerad: {medlem.Namn} (ID: {medlem.Id})");
    }

    static void SkapaMatch()
    {
        if (medlemmar.Count < 2)
        {
            Console.WriteLine("\nMinst två medlemmar krävs för en match!");
            return;
        }

        Console.WriteLine("\nVälj två spelare (ange ID):");
        foreach (var medlem in medlemmar)
        {
            Console.WriteLine($"{medlem.Id}: {medlem.Namn}");
        }

        Console.Write("\nID för spelare 1: ");
        int id1 = int.Parse(Console.ReadLine());
        Console.Write("ID för spelare 2: ");
        int id2 = int.Parse(Console.ReadLine());

        Medlem spelare1 = medlemmar.Find(m => m.Id == id1);
        Medlem spelare2 = medlemmar.Find(m => m.Id == id2);

        if (spelare1 == null || spelare2 == null || spelare1 == spelare2)
        {
            Console.WriteLine("\nOgiltiga val, försök igen.");
            return;
        }

        Match match = new Match(spelare1, spelare2);

        Console.Write("\nPoäng för spelare 1: ");
        int poäng1 = int.Parse(Console.ReadLine());
        Console.Write("Poäng för spelare 2: ");
        int poäng2 = int.Parse(Console.ReadLine());

        match.BestämVinnare(poäng1, poäng2);

        if (match.Vinnare != null)
            Console.WriteLine($"\nVinnaren är {match.Vinnare.Namn}!");
        else
            Console.WriteLine("\nMatchen blev oavgjord.");
    }
}
