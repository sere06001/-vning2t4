using System;
using System.Collections.Generic;
namespace övning2t4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv förnamn: ");
            string förnamn = Console.ReadLine();
            Console.Write("Skriv efternamn: ");
            string efternamn = Console.ReadLine();
            Person person = new Person();
            person.Namn = förnamn;
            person.Efternamn = efternamn;
            Console.WriteLine();

            Console.Write($"Vilket år är du född?: ");
            int år = int.Parse(Console.ReadLine());
            Console.Write("Vilken månad är du född? Skriv månaden som siffra: ");
            int månad = int.Parse(Console.ReadLine());
            Console.Write("Vilken dag är du född? Skriv som siffra: ");
            int dag = int.Parse(Console.ReadLine());
            person.Födelsedag = new DateTime(år, månad, dag);
            person.År = person.BeräknaÅlder(person.Födelsedag);
            Console.WriteLine();

            Console.Write("Hur lång är du i cm?: ");
            person.Längd = double.Parse(Console.ReadLine());
            Console.Write("Hur mycket väger du i kg?: ");
            person.Vikt = double.Parse(Console.ReadLine());

            person.BMI = Math.Round(person.Vikt / (person.Längd / 100 * person.Längd / 100), 1);

            Console.WriteLine();
            Console.Write($"Du heter {person.Namn} {person.Efternamn}, din BMI är {person.BMI}, du är {person.År} och du är ");
            if (person.Myndig)
            {
                Console.Write("myndig.");
            }
            else
            {
                Console.Write("inte myndig.");
            }
            Console.ReadKey();
        }
    }
}