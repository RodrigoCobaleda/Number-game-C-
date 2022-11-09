using System;

class program
{
    static void Main(string[] args)
    {
        Console.Title = "Random number game";
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Random random = new Random();
        // creates the random number and stores it as a variable
        while (true)
        {
            
            Console.WriteLine("I'm thinking of a number between 1 and 100\n");
            int number = random.Next(1,100);
            // sets it as a random number between 1 to 100

            Console.WriteLine("Guess the number\n");
            int guess = Convert.ToInt32(Console.ReadLine());
            // int input 

            if (guess < number)
            {
                Console.WriteLine("Guess is too low ");
            }
            else if (guess > number)
            {
                Console.WriteLine("Guess too high");
            }
            else if (guess == number)
            {
                Console.WriteLine("You win !");
                break;
            }
        }
    }
}