using System;

namespace Demo;

public class Program
{
    static void Main()
    {
        // Variables and Types
        int intNum = 50;
        double doubleNum = 5.99;
        float floatNum = 5.66F;
        byte byteNum = 255;
        char charLetter = 'A';
        bool isTrue = false;
        string userText = "Hi!";

        // Customize your output using {index order of variables}
        Console.WriteLine(" int: {0}\n double: {1}\n float: {2}\n byte: {3}\n char: {4}\n bool: {5}\n string: {6}", intNum, doubleNum, floatNum, byteNum, charLetter, isTrue, userText);

        Console.WriteLine("-------------------");
        // Original way using "+"
        Console.WriteLine("int: " + intNum + ", double: " + doubleNum + ", etc");

        Console.WriteLine("-------------------");

        // string interpolation using "$"
        Console.WriteLine($"int: {intNum}, double: {doubleNum}, etc");

    }
}
