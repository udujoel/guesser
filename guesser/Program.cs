using System;

namespace guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Guesser", name;
            Console.WriteLine("What is your name? ");
            name = Console.ReadLine();
            GreetUser(name, appName);

            Random random = new Random();
            
            int correctguess = random.Next(0,9);
            int guess;
            string input;

            Message("Guess a number between 0-9:",ConsoleColor.Green);

            while (true)
            {
                input = Console.ReadLine();
                if (!int.TryParse(input,out guess))
                {
                    Message("Enter a valid number(0-9)",ConsoleColor.Red);
                    continue;
                }
                else
                {
                    guess = Int32.Parse(input);
                }
                if ( guess == correctguess)
                {
                    Message("Congrats!!!",ConsoleColor.Yellow);
                    Message("Do you want to play again? -Y/N",ConsoleColor.Green);
                    string response = Console.ReadLine();
                    if (response.ToUpper() =="Y")
                    {
                        Message("Guess a number between 0-9:", ConsoleColor.Green);
                        continue;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Message("Sorry. Try Again!",ConsoleColor.Red);
                }
            }


        }

        static void GreetUser(string userName, string app)
        {
            Message($"Hello {userName}, Welcome to {app} Game!",ConsoleColor.Green);
        }

        static void Message(string msg, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
