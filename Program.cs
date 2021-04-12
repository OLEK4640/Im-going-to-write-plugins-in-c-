using System;
using System.Collections.Generic;
using System.Threading;

namespace Pieniądze_grabber
{
    class Pieniądze_grabber
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Podaj imię:");
            string imię = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj Numer karty kredytowej (ten z tyłu):");
            string nr = Console.ReadLine();
            Console.WriteLine("Podaj pin do karty:");
            string pin = Console.ReadLine();
            Console.WriteLine("Podaj swój pesel:");
            string pesel = Console.ReadLine();
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            List<string> gufno = new List<string>();
            gufno.Add($"Imię : {imię}");
            gufno.Add($"Nazwisko : {nazwisko}");
            gufno.Add($"Numer karty kredytowej: {nr}");
            gufno.Add($"Pin: {pin}");
            gufno.Add($"Pesel: {pesel}");
            Console.WriteLine("Pieniądze zostały pobrane pomyślnie !");
            foreach (var pyra in gufno)
            {
                Console.WriteLine(pyra);
            }
            Thread.Sleep(6000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Myślałeś że to już koniec?");
            Thread.Sleep(500);
            Console.WriteLine("Otóż nie.");
            Thread.Sleep(1500);
            Console.WriteLine("Odpowiadaj na pytania!");
            Thread.Sleep(2000);
            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("Pytanie pierwsze: W jakim języku jest napisany ten program?");
            string odpowiedz1 = Console.ReadLine();
            if (odpowiedz1 == "c#")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Prawidłowa odpowiedź!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zła odpowiedź!");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Pytanie drugie: jak nazywa się platforma na której rozmawiamy?");
            string odpowiedz2 = Console.ReadLine();
            if (odpowiedz2 == "discord")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Prawidłowa odpowiedź!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zła odpowiedź!");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Pytanie trzecie: jak sie nazywa gra multiplayer z scp");
            string odpowiedz3 = Console.ReadLine();
            if (odpowiedz3 == "SCPSL")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Prawidłowa odpowiedź!");
                Thread.Sleep(6969);
                Console.WriteLine("Naura frajerze :)");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zła odpowiedź!");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
        }
    }
}