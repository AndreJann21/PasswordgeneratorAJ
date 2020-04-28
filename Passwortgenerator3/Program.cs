using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwortgenerator3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Andere Methoden verwenden
            RandomNumberGenerator generator = new RandomNumberGenerator();

            string pass = generator.RandomPassword(); Console.WriteLine($"Random Password {pass}"); Console.ReadKey();

        }
    }
}
public class RandomNumberGenerator
{
    //Generate a random number bretween two numbers
    public int RandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
    
        //Generiere eine zufällige Zeichenfolge mit einer bestimmten Größe und Groß- / Kleinschreibung.
        //Wenn der zweite Parameter true ist, wird die Rückgabezeichenfolge in Kleinbuchstaben geschrieben

        public string RandomString(int size, bool lowerCase)
    {
        StringBuilder builder = new StringBuilder(); Random random = new Random();
        char ch;
        for (int i = 0; i < size; i++)
        {
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))); builder.Append(ch);
        }
        if (lowerCase)
            return builder.ToString().ToLower();
        return builder.ToString();
    }

    //Generate a random password of a given length (optional)
    public string RandomPassword(int size = 0)
    {
        StringBuilder builder = new StringBuilder();
        string length, upperCase, lowerCase, specialChars, digits;
        int l1, u2, lo3, sp4, di5, min, max;
        bool LowerCase;
        Console.Write("Länge des Passworts: "); length = Console.ReadLine();
        if (length == "") { Console.Clear(); Console.WriteLine("Bis bald!"); System.Threading.Thread.Sleep(1000); Environment.Exit(0); }
        try
        {
            l1 = Convert.ToInt32(length);
            Console.WriteLine("\n");
        }
        catch (FormatException)
        {
            Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Unable to parse '{length}'");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.Write("Länge des Passworts (z.B.: 5,...): "); length = Console.ReadLine();
            } while (!int.TryParse(length, out l1));
        }
        do
        {
            Console.Write("Anzahl der Großbuchstaben: "); upperCase = Console.ReadLine();
            if (upperCase == "") { Console.Clear(); Console.WriteLine("Bis bald!"); System.Threading.Thread.Sleep(1000); Environment.Exit(0); }
            try
            {
                u2 = Convert.ToInt32(upperCase);
                Console.WriteLine("\n");
            }
            catch (FormatException)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Unable to parse '{upperCase}'");
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                do
                {
                    Console.Write("Anzahl der Großbuchstaben (z.B.: 1/2/...): "); upperCase = Console.ReadLine();
                } while (!int.TryParse(upperCase, out u2));
            }
            if (u2 > l1)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Die Anzahl der Großbuchstaben darf nicht größer sein, als die Passwortlänge!!!");
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
            }
        } while (u2 > l1);
        do
        {
            Console.Write("Anzahl der Kleinbuchstaben: "); lowerCase = Console.ReadLine();
            if (lowerCase == "") { Console.Clear(); Console.Write("Bis bald!"); System.Threading.Thread.Sleep(1000); Environment.Exit(0); }
            try
            {
                lo3 = Convert.ToInt32(lowerCase);
                Console.WriteLine("\n");
            }
            catch (FormatException)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Unable to parse '{lowerCase}'");
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                do
                {
                    Console.Write("Anzahl der Kleinbuchstaben (z.B.: 1/2/...): "); lowerCase = Console.ReadLine();
                } while (!int.TryParse(lowerCase, out lo3));
            }
            if (u2 + lo3 > l1)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Die Gesamtanzahl der Groß- & Kleinbuchstaben  darf nicht größer sein, als die Passwortlänge!!!");
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
            }
        } while (u2 + lo3 > l1);
        do
        {
            Console.Write("Anzahl der Sonderzeichen: "); specialChars = Console.ReadLine();
            if (specialChars == "") { Console.Clear(); Console.Write("Bis bald!"); System.Threading.Thread.Sleep(1000); Environment.Exit(0); }
            try
            {
                sp4 = Convert.ToInt32(specialChars);
                Console.WriteLine("\n");
            }
            catch (FormatException)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Unable to parse '{specialChars}'");
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                do
                {
                    Console.Write("Anzahl der Sonderzeichen (z.B.: 1/2/...): "); specialChars = Console.ReadLine();
                } while (!int.TryParse(specialChars, out sp4));
            }
            if (u2 + lo3 + sp4 > l1)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Die Anzahl der Sonderzeichen ist zu groß!!!");
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
            }
        } while (u2 + lo3 + sp4 > l1);
        do
        {
            do
            {
                Console.Write("Anzahl Zahlen/Ziffern:(Max 7) "); digits = Console.ReadLine();

                if (digits == "") { Console.Clear(); Console.Write("Bis bald!"); System.Threading.Thread.Sleep(1000); Environment.Exit(0); }
                try
                {
                    di5 = Convert.ToInt32(digits);
                    Console.WriteLine("\n");
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"Unable to parse '{digits}'");
                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                    do
                    {
                        Console.Write("Anzahl der Zahlen/Ziffern (z.B.: 1/2/...): "); digits = Console.ReadLine();
                    } while (!int.TryParse(digits, out di5));
                }
                if (u2 + lo3 + sp4 + di5 > l1)
                {
                    Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Die Anzahl der Zahlen/Ziffern ist zu groß!!!");
                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                }
                else if (u2 + lo3 + sp4 + di5 < l1)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow; Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Achte darauf, ob die Passwortlänge eingehalten wird. ");
                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Die Anzahl der Zahlen/Ziffern ist zu klein!!!");
                    Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
                }
            } while (u2 + lo3 + sp4 + di5 != l1);


            Console.ReadKey();
            builder.Append(RandomString(u2, false));
            if (di5 == 1)
            {
                min = 0; max = 9;
                builder.Append(RandomNumber(min, max));
            }
            else if (di5 == 2)
            {
                min = 10; max = 99;
                builder.Append(RandomNumber(min, max));
            }
            else if (di5 == 3)
            {
                min = 100; max = 999;
                builder.Append(RandomNumber(min, max));
            }
            else if (di5 == 4)
            {
                min = 1000; max = 9999;
                builder.Append(RandomNumber(min, max));
            }
            else if (di5 == 5)
            {
                min = 10000; max = 99999;
                builder.Append(RandomNumber(min, max));
            }
            else if (di5 == 6)
            {
                min = 100000; max = 999999;
                builder.Append(RandomNumber(min, max));
            }
            else if (di5 == 7)
            {
                min = 1000000; max = 9999999;
                builder.Append(RandomNumber(min, max));
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("Du kannst höchstens 7 Zahlen in deinem Passwort verwenden");
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White;
            }
        } while (di5 > 7);
        builder.Append(RandomString(lo3, true));
        return builder.ToString();
    }

}
     
