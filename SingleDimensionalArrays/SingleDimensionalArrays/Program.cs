using System;

namespace SingleDimensionalArrays;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements: ");

        var input = Console.ReadLine();
        int numberOfElements = Convert.ToInt32(input);

        double[] numbers = new double[numberOfElements];
        double sum = 0;

        // enter the elements and compute the sum of the elements
        Console.WriteLine("Enter the numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            var inputForNumbers = Console.ReadLine();
            double elements = Convert.ToDouble(inputForNumbers);
            numbers[i] = elements; // store 
            sum += numbers[i]; // add 
        }

        double average = sum / numberOfElements; // compute the average value

        int count = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > average) count++;
        }

        Console.WriteLine("Average is {0:N4}", average);
        Console.WriteLine($"Number of elements above the average is {count}");

    }
}