using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int x = int.Parse(grade);


        string letter = "";

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = x % 10;
        string plusMinus = "";
        if (lastDigit >= 7)
        {
            plusMinus = "+";
        }
        else if (lastDigit < 3)
        {
            plusMinus = "-";
        }
        else
        {
            plusMinus = "";
        }

        Console.WriteLine($"Your letter grade is {letter}{plusMinus}.");

        if (x >= 60)
        {
            Console.WriteLine("Congradulations, you passed.");
        }
        else
        {
            Console.WriteLine("You did not pass. Good luck.");
        }

    }
}