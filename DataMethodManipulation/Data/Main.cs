using System;
using System.Collections.Generic;

namespace Data
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var r = new Random ();
			List<int> Numbers = new List<int> ();
			for (var i = 0; i < 10; i++)
			{
				Numbers.Add(r.Next());
			}

			foreach (var num in Numbers) 
			{
				Console.WriteLine (num);
			} 
		}
	}
}
