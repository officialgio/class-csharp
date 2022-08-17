using System;

namespace Operations;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----Arithmetic Operators-----");
        int num1 = 5;
        int num2 = 2;
        int num3 = 5;

        // Operators in parenthesis are evaluated first.
        Console.WriteLine(num3 * (num1 / num2)); // 10

        // cast the answer to a double
        Console.WriteLine(num3 * ((double)num1 / num2)); // 12.5

        // More casting examples
        Console.WriteLine("-----More casting-----");
        double myDouble = 10.78;
        int myInt = (int)myDouble; // Manual casting: double to int

        Console.WriteLine(myDouble); // 10.78
        Console.WriteLine(myInt); // 10

        Console.WriteLine("-----Assignment Operators-----");
        // Assignment Operators
        int i = 3;
        int j = 6;

        i += 3; // add 3 and assign it 
        j -= 3; // sub 3 and assing it

        // equivalent to
        //i = i + 3;
        //j = j - 3;

        Console.WriteLine(i); // 6
        Console.WriteLine(j); // 3
    }
}
