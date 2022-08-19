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
    }
}
