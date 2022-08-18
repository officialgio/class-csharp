using System;

namespace MoreLogic;

public class IncremntAndDecrementOperators
{
	static void Main()
	{
        int i = 1;
        //int j = i++; uncomment for i++
        int j = ++i; // uncomment if you're going to use line 10

        Console.WriteLine("i++: j = {0}, i = {1}", j, i);
        Console.WriteLine("++i: j = {0}, i = {1}", j, i);
    }
}
