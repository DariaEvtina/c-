using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int hinne = rnd.Next(1, 7);
            Console.WriteLine("Hinne: {0}",hinne);
            Console.ReadLine();
            string tekst="???";
            switch(hinne)
            {
                case 1: tekst = "Õpi veel!";break;
                case 2: tekst = "Õpi natuke veel!"; break;
                case 3: tekst = "Rahuldav!"; break;
                case 4: tekst = "Hea!"; break;
                case 5: tekst = "Väga hea!"; break;
                default:
                    tekst = "Viga";
                    break;
            }
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WriteLine(tekst);
            ConsoleKeyInfo nupp = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Backspace");
                nupp = Console.ReadKey();
            } while (nupp.Key!=ConsoleKey.Backspace);
            Console.ReadLine();
            Console.WriteLine("Töö failidega");
            string a;
            Console.WriteLine("Y - on vaja salvetada failisse");
            Console.WriteLine("N - on vaja lugeda failist");
            nupp = Console.ReadKey();
            if (nupp.Key==ConsoleKey.Y)
            {
                StreamWriter file = new StreamWriter(@"..\..\texts.txt", true);
                file.WriteLine(hinne + " " + tekst);
                file.Close();
                a = hinne + " " + tekst;
                Console.WriteLine("Failisse oli salvestatud:{0}", a);
            }
            else if (nupp.Key == ConsoleKey.N)
            {
                Console.WriteLine("Failis on jarmine Information:");
                StreamReader FILIST = new StreamReader(@"..\..\texts.txt");
                a = FILIST.ReadToEnd();
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("Puhkame");
            }
            Console.ReadLine();
        }
    }
}
