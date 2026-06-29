using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a random number generator
        Random randomGenerator = new Random();

        // Generate a random number between 1 and 100
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}