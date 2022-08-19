using System;

namespace MoreLogic;

public class IncremntAndDecrementOperators
{
	static void Main()
	{
		int sum = 0;

		for (int i = 0; i <= 4; i++)
		{
			sum += i; // 0 + 1 + 2 + 3 + 4 = 10
			Console.WriteLine("Loop {0}", i);
        }
		Console.WriteLine(sum);




		//int sum = 0; 
		//for (int i = 0; i <= 4; i++)
		//{
		//	sum += (int)Math.Pow(i, 2);
		//	Console.WriteLine(i);
		//}
		//Console.WriteLine(sum);
    }
}
