using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome.");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Enter your username: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Enter your user number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int number1)
    {
        int squared = number1 * number1;
        return squared;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the number squared is {square}.");
    }
    }
}