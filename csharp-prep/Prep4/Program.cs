using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();

        string response = "";
        int total = 0;
        while (response != "0")
        {
            Console.WriteLine("Enter Number: ");
            response = Console.ReadLine();
            int responseNumber = int.Parse(response);
            if (responseNumber != 0)
            {
                numbers.Add(responseNumber);
            }
            total = total + responseNumber;
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The sum is : {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");

        int smallestNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number < smallestNumber)
            {
                smallestNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestNumber}");

    }
}