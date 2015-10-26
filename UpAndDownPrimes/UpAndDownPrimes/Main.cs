using System;

namespace UpAndDownPrimes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var val = BeforeAfterPrimes.PrimeBefAft (100);
				Console.WriteLine ("The closest prime numbers are: {0}   {1}",val[0],val[1]);
		}
	}
}
