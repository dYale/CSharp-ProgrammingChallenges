using System;
using System.Linq;
using System.Collections.Generic;

public class Sumpowdig {

	public static void Main (string[] args)
	{
		Console.WriteLine ("Equal POWER!");
	}
		public static int[] GetIntArray(int num)
		{
			List<int> listOfInts = new List<int>();
			while(num > 0)
			{
				listOfInts.Add(num % 10);
				num = num / 10;
			}
			listOfInts.Reverse();
			return listOfInts.ToArray();
		}
		
		public static long[] EqSumPowDig(long hmax, int exp) 
		{
			List<long> results = new List<long>();
			for(int i = 2; i <= hmax ; i++)
			{
				if(Sumpowdig.GetIntArray(i).Aggregate(0, (x, y) => x += (int)Math.Pow(y, exp)) == i){ results.Add(i); }
			}
			return results.ToArray();
		}
	}
/*
There are more efficient way to do this, still learning methods. Will come back and iterate. 
Chose to use aggregate to learn it. Could use a normal for loop and avoid converting a number into an Array.
Alternative solution below

using System.Collections.Generic;

public class Sumpowdig {
	
	public static long[] EqSumPowDig(long hmax, int exp) 
	{
		List<long> numbers = new List<long>();
		for (long i = 2; i <= hmax; i++) if ( digPowSum (i, exp) == i ) numbers.Add(i);
		return numbers.ToArray();
	}
	
	private static long digPowSum(long num, int exp) 
	{
		long sum = 0;
		while(num > 0)
		{
			sum += (long) System.Math.Pow( (num % 10), exp );
			num /= 10;
		}
		return sum;
	}
}
*/








