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
            Console.WriteLine("c=12*x-18*(b-a)");
            int a_ = rnd.Next(0, 10);
            int b = rnd.Next(0, 10);
            int x = rnd.Next(0, 10);
            float c = 12 * x - 18*(b - a_);
            Console.WriteLine("Vastus on: {0}", c);
            Console.WriteLine("Kirjuta sinu nimi ja perekonanimi:");
            string FIO = Console.ReadLine();
            Console.WriteLine("Kirjuta oma rühm:");
            string ruhm = Console.ReadLine();
            Console.WriteLine("Kirjuta oma variandi number:");
            string n = Console.ReadLine();
            Console.WriteLine("Kirjuta sinu vanus:");
            string vana = Console.ReadLine();
            Console.WriteLine("Kirjuta sinu sugu:");
            string sugu = Console.ReadLine();
            Console.WriteLine("labotitöö art ja pealkiri:");
            string arv_ja_pealkiri = Console.ReadLine();
            StreamWriter files = new StreamWriter(@"..\..\vastus.txt", true);
            files.WriteLine("a:" + a_ +", "+ "b:" + b + ", " + "x:" + x);
            files.WriteLine("c=12*x-18*(b-a)" + " " + "Vastus on: " + c);
            files.WriteLine(FIO + ", " + sugu + ", " + vana+ ", " + ruhm + "\n" + n + ", " + arv_ja_pealkiri);
            files.Close();
            Console.WriteLine("Kirjuta a:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            float c_ = 12 * x - 18 * (b - a1);
            Console.WriteLine("Vastus on: {0}", c_);
            Console.ReadLine();
        }
    }
}
