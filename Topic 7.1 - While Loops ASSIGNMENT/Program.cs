using System.Net.Security;

namespace Topic_7._1___While_Loops_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            bool done = false;
            int points = 3;
            Console.WriteLine("Welcome to the worst casino! You will be playing a game of chance. ");
            while (points > 0)
            {
                Console.WriteLine("Enter heads or tails");
                int coin = rand.Next(0, 2);
                
                if ()
                {
                    Console.WriteLine("Heads");
                }
                else
                {
                    Console.WriteLine("Tails");
                }
                int num1 = Convert.ToInt32(Console.ReadLine());
                Random rand = new Random();
                int num2 = rand.Next(1, 7);
                if (num1 == num2)
                {
                    Console.WriteLine("Great job! You get to keep your points!!");
                }
                else
                {
                    Console.WriteLine("You suck! You lose 1 point!");
                    points--;
                }
                Console.WriteLine("You have " + points + " points.");

                Console.WriteLine("Would you like to continue? Who knows, you might get lucky.");
                string answer = Console.ReadLine();
                if (answer == "no")
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
                    Console.WriteLine("You lose. How does it feel to fail?");
                    done = true;

                }
                




            }
        }
    }
}
