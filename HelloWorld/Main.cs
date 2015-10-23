using System;

namespace csharp_station 
{
	// nested namespace
	namespace tutorial 
	{
		class myExample1 
		{
			public static int myPrint1() 
			{
				Console.WriteLine("First Example of calling another namespace member.");
				return 1;
			}
			public static void myPrint2() 
			{
				Console.WriteLine("Second Example of calling another namespace member.");
			}
		}
	} 
}
