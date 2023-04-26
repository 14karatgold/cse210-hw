using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int guessNumber = 0;
        Console.WriteLine("Guess a number: ");
        string guessString = Console.ReadLine();
        guessNumber = int.Parse(guessString);

        while (guessNumber != number)
        {
            if (guessNumber < number)
            {
                Console.WriteLine("Your guess is too small.");
            }

            if (guessNumber > number)
            {
                Console.WriteLine("Your guess is too big.");
            }
            Console.WriteLine("Guess a number: ");
            guessString = Console.ReadLine();
            guessNumber = int.Parse(guessString);
        }

        Console.WriteLine("That was the right number.");
    }
}