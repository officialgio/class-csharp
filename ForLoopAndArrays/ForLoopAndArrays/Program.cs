using System;

namespace ForLoopAndArrays;

public class Program
{
    static void Main(string[] args)
    {
        //type[] arrayName;

        int[] array1 = new int[3]; // size

        // Declare and set array element values.
        int[] array2 = new int[] { 1, 3, 5, 7, 9 };

        // Alternative syntax.
        int[] array3 = { 1, 2, 3, 4, 5, 6 };

        Console.WriteLine("------Length of Array2------");
        // lenght of array2
        int lengthOfArray = array2.Length; // 5
        Console.WriteLine(lengthOfArray);

        // assign values to the elements of array2
        array2[0] = 10;
        array2[1] = 20;
        array2[2] = 30;
        // . . .

        // diff types
        int[] intArray;
        double[] doubleArray;
        byte[] byteArray;
        float[] floatArray;


        // with if statement
        if (array1[0] > array1[1])
        {
            // do something.. .
        }

        Console.WriteLine("------Looping through Array2------");
        // Looping through Array2
        for (int i = 0; i < array2.Length; i++)
        {
            Console.WriteLine($"\nindex {i}"); // print index
            Console.WriteLine($"element {array2[i]}"); // print elements 
        }

        Console.WriteLine("------FindMax------");
        var max = FindMax(array2);
        Console.WriteLine($"The max in the array2 is {max}");
    }

    // Find max by looping through
    public static int FindMax(int[] arr)
    {
        int largest = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > largest)
                largest = arr[i];
        }

        return largest;
    }
}
