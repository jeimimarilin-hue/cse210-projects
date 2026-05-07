using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Calculation of Sum
        int totalSum = 0;
        foreach (int number in numbers)
        {
            totalSum += number;
        }

        Console.WriteLine($"The sum is: {totalSum}");

        // Calculation of Average
        float average = ((float)totalSum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Finding the Maximum
        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }

        Console.WriteLine($"The max is: {maxNumber}");
    }
}