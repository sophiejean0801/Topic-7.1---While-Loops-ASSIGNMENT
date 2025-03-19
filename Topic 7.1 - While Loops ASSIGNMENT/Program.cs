using System;
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
            int flip, heads = 0, tails = 1; 
            Random random = new Random();

           // heads is 0 and tails is 1

            int points = 3;
            Console.WriteLine("Welcome to the worst casino! You will be playing a game of chance. ");
            while (!done)
            {
                Console.WriteLine("Enter heads or tails");
                guess = Console.ReadLine();
                flip = random.Next(0, 2);
                
                if (guess == "heads" && guess == heads)
                {
                   

                }
                if (guess == "tails")
                {
                    
                }

                if (flip == flip2)
                {
                    Console.WriteLine("You're actually somewhat lucky! Look at you go!");
                }
                
                


                
                       
            }
        }
    }
}
