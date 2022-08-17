using System;

namespace MoreLogic;

public class Program
{
    static void Main()
    {
        // code along and answer for HW
        Console.WriteLine("-----Homework solution-----");
        bool isTrue = false;
        double num1 = 4;
        double num2 = 3;

        // equivalent to (num1.GetType() == num2.GetType())
        if (num1.GetType().Equals(num2.GetType())) {
            isTrue = true; // you may use this to print something if you'd like
            Console.WriteLine("They're the same type!");
        }
        else {
            Console.WriteLine("They're not the same type!");
        }

        // Practice using C# methods
        Console.WriteLine("----=Practice using C# Methods-----");

        //compare the values by -1, 0, 1
        Console.WriteLine("-----using .CompareTo()-----");
        int compare = num1.CompareTo(num2);
        Console.WriteLine(compare); // 1 b/c num1 is greater

        Console.WriteLine("-----using .ToString()-----");
        string numAsString = num1.ToString();
        Console.WriteLine(num1); // "4" NOTE: you don't see the quotations

        // get the type of the variable
        Console.WriteLine("-----using .GetType()-----");
        Console.WriteLine(num1.GetType()); //System.Double
    }
}
