﻿using System;
using System.Net.Security;

namespace Topic_7._1___While_Loops_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            bool done = false;
            string guess;
            int flip, points = 3, heads = 0, tails = 1; 
            Random random = new Random();

           // heads is 0 and tails is 1

            Console.WriteLine("Welcome to the worst casino! You will be playing a game of chance. ");
            while (!done)
            {
                Console.WriteLine("Enter heads or tails");
                guess = Console.ReadLine();
                flip = random.Next(0, 2);

                if (guess == "heads" && flip == 0)
                {
                    Console.WriteLine("The coin landed on heads! You win!");
                    Console.WriteLine("You now have " + points + " points!");
                }
                if (guess == "tails" && flip == 1 )
                {
                    Console.WriteLine("The coin landed on tails! You win!");
                    Console.WriteLine("You now have " + points + " points!");
                }
                if (guess == "heads" && flip == 1)
                {
                    Console.WriteLine("You guessed heads and the coin landed on tails! You suck!");
                    points--;
                    Console.WriteLine("You now have " + points + " points!");
                }
                if (guess == "tails" && flip == 0)
                {
                    Console.WriteLine("You guessed tails and the coin landed on heads! You suck!");
                    points--;
                    Console.WriteLine("You now have " + points + " points!");
                }
                Console.WriteLine("Would you like to continue?");
                if (Console.ReadLine() == "no")
                {
                    Console.WriteLine("Coward.");
                    done = true;
                }
                else
                {
                    done = false;
                }
               while (points == 0)
               {
                    Console.WriteLine("You have no more points! You loser!");
                    done = true;
               }






            }
        }
    }
}
