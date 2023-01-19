using System;
using System.Collections.Generic;

namespace ottomaatti
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asiakirja/lista jossa käyttäjät ja niiden pin koodit
            Dictionary<string, int> users = new Dictionary<string, int>
            {
                {"Jenny Jalo", 1234},
                {"Pentti Peura", 5678},
                {"Elon Musk", 91011}
            };

            Console.WriteLine("Tervetuloa tomaatille");

            // Pyydetään käyttäjää syöttämään 
            Console.Write("Syötä nimesi: ");
            string name = Console.ReadLine();
            Console.Write("Syötä pin koodisi: ");
            int pin = int.Parse(Console.ReadLine());

            // Tarkistetaan nimi ja pinkoodi
            if (!users.ContainsKey(name) || users[name] != pin)
            {
                Console.WriteLine("Väärä nimi tai pin");
                return;
            }

            Console.WriteLine("Hei, " + name + "! Valitse seuraavista vaihtoehdoista?");

            // Näytä käyttäjälle valinnat
            Console.WriteLine("1. Tarkista saldo");
            Console.WriteLine("2. Nosta rahaa");
            Console.WriteLine("3. Talleta rahaa");
            Console.WriteLine("4. Sulje");

            // Tallennetaan käyttäjän saldo
            decimal balance = 1000;

            while (true)
            {
                Console.Write("Valitse vaihtoehto: ");
                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    // Katsotaan saldoa
                    Console.WriteLine("Saldosi on: " + balance);
                }
                else if (option == 2)
                {
                    // Nostetaan rahaa
                    Console.Write("Paljonko haluat nostaa: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    if (amount > balance)
                    {
                        Console.WriteLine("Ei ole riittävästi katetta");
                    }
                    else
                    {
                        balance -= amount;
                        Console.WriteLine("Nosto suoritettu: " + amount);
                    }
                }
                else if (option == 3)
                {
                    // Talletetaan rahaa
                    Console.Write("Syötä summa kuinka paljon talletetaan: ");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    balance += amount;
                    Console.WriteLine("Talletettu onnistuneesti " + amount);
                }
                else if (option == 4)
                {
                    // Exit
                    break;
                }
                else
                {
                    Console.WriteLine("Väärä valinta");
                }
            }
        }
    }
}
