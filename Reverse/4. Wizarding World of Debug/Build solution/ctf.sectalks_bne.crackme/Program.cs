using System;
using System.Diagnostics;
using System.Threading;

/***
 * CrackMe Challenge made for the Brisbane SecTalks 2017 CTF Challenge (http://www.sectalks.org/)
 * Created by @codingo_
 * 11-April-2017
 *
 * Edited by Oliver E. Nilssen
 * for d:hack and d:ctf @Dips
 * 13-September-2021
 *
 * Please compile using the debug manifest to ensure 'string' text is included within the binary.
 * No dependancies besides .net installed need to be present. Just the cracknet.exe can be included in the
 * ctf release. Name is intended to be a hint.
 * **/

namespace d.ctf.dips.crackme
{
    class Program
    {
        private static void Main(string[] args)
        {
            const string pointless = "flag{Not a real flag. Strings would be too easy";
            Debug.WriteLine(pointless);

            Program.PrintBanner();

            var guesses = 5;

            while (true)
            {
                if (guesses < 1) PrintGameOver();

                PrintTimer(3);
                PrintGuesses(guesses);

                Console.Write("Enter password: ");
                var input = Console.ReadLine();

                var password =
                Crypto.DecryptStringAES("EAAAANUSg61PJP7GbtWY+ToEVFRtKC827v26RUBENPkGx2LAkIEwSV+qAXW/I7bV+P/GjrcWWNt1SZspPPesajIzgaw=");
                
                if (input != null && input.Equals(password))
                {
                    Console.WriteLine($"Success! Flag: {Crypto.DecryptStringAES("EAAAAOVgRTZdZ74pjduFQHlhyPw1yUoFCDKDZu+BUWkMLVh6sJfbkbw9bqiIG9MANOZVNJ8zvmQ2maWOVaXiVoHXr2c=")}");

                    HarryPotter();
                    Environment.Exit(0);
                }

                guesses--;
                
                Console.WriteLine($"Incorrect! Please wait to try again.");

                Console.Beep(350, 250);
                Console.Beep(300, 500);
            }
        }

        public static void PrintBanner()
        {
            Console.WriteLine("\n  __________________________________________");
            Console.WriteLine("||    _____      __    ____      ______     ||");
            Console.WriteLine("||   |  __  \\   |  |  |  _  \\   |  ____|    ||");
            Console.WriteLine("||   | |   \\ \\  |  |  | |_|  |  | |____     ||");
            Console.WriteLine("||   | |   |  | |  |  |   __/   |____  |    ||");
            Console.WriteLine("||   | |__/  /  |  |  |  |       ____| |    ||");
            Console.WriteLine("||   |______/   |__|  |__|      |______|    ||");
            Console.WriteLine("||__________________________________________||");
        }

        private static void PrintGameOver()
        {
            Console.WriteLine("      _____          __  __ ______    ______      ________ _____  _ ");
            Console.WriteLine("     / ____|   /\\   |  \\/  |  ____|  / __ \\ \\    / /  ____|  __ \\| |");
            Console.WriteLine("    | |  __   /  \\  | \\  / | |__    | |  | \\ \\  / /| |__  | |__) | |");
            Console.WriteLine("    | | |_ | / /\\ \\ | |\\/| |  __|   | |  | |\\ \\/ / |  __| |  _  /| |");
            Console.WriteLine("    | |__| |/ ____ \\| |  | | |____  | |__| | \\  /  | |____| | \\ \\|_|");
            Console.WriteLine("     \\_____/_/    \\_\\_|  |_|______|  \\____/   \\/   |______|_|  \\_(_)");
            Console.WriteLine(" ________________________________________________________________________ ");
            Console.WriteLine("|________________________________________________________________________|");

            HarryPotter();

            Environment.Exit(0);
        }

        public static void PrintTimer(int seconds)
        {
            for (var i = seconds; i >= 0; --i)
            {
                var originalLeft = Console.CursorLeft;
                var originalTop = Console.CursorTop;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.CursorLeft = 0;
                Console.CursorTop = 0;

                Console.Write("You can make another guess in: {0}", i);

                Console.CursorLeft = originalLeft;
                Console.CursorTop = originalTop;

                Thread.Sleep(1000);
            }
        }

        public static void PrintGuesses(int remainingGuesses)
        {
            var originalLeft = Console.CursorLeft;
            var originalTop = Console.CursorTop;

            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            Console.ForegroundColor = ConsoleColor.White;

            if (remainingGuesses == 1)
            {
                var originalColour = Console.BackgroundColor;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write($"You only have one guess remaining!");
                Console.BackgroundColor = originalColour;
            }
            else
            {
                Console.Write($"You have {remainingGuesses}/5 guesses remaining!!");
            }
            
            Console.CursorLeft = originalLeft;
            Console.CursorTop = originalTop;
        }

        private static void HarryPotter()
        {
            int C = 264;
            var Cs = 277;
            int D = 297;
            var Ds = 311;
            int E = 330;
            int F = 352;
            var Fs = 349;
            int G = 396;
            var Gs = 415;
            int A = 440;
            var As = 466;
            int B = 495;

            int note = 1000;
            int half = 1000 / 2;
            int quarter = 1000 / 4;
            int eighth = 1000 / 8;

            Console.Beep(D, quarter);
            Console.Beep(G, half);
            Console.Beep(As, eighth);
            Console.Beep(A, quarter);
            Console.Beep(G, half);
            Thread.Sleep(eighth);
            Console.Beep(D, quarter);
            Console.Beep(C, half);
            Thread.Sleep(quarter);
            Console.Beep(A, half);
            Thread.Sleep(quarter);
            Console.Beep(G, half);
            Console.Beep(As, eighth);
            Console.Beep(A, quarter);
            Console.Beep(Fs, half);
            Thread.Sleep(half);
            Console.Beep(Gs, quarter);
            Console.Beep(D, note);
            Thread.Sleep(note);
            Console.Beep(D, quarter);
            Console.Beep(G, half);
            Console.Beep(As, eighth);
            Console.Beep(A, quarter);
            Console.Beep(G, quarter);
            Thread.Sleep(quarter);
            Console.Beep(D, quarter);
            Console.Beep(F, half);
            Thread.Sleep(quarter);
            Console.Beep(E, quarter);
            Console.Beep(Ds, note);
            Console.Beep(B, quarter);
            Console.Beep(Ds, half);
            Console.Beep(D, eighth);
            Console.Beep(Cs, quarter);
            Console.Beep(Cs, note);
            Console.Beep(As, quarter);
            Console.Beep(G, note);
            Thread.Sleep(half);
        }
    }
}
