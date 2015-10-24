using System;

namespace OOPractice
{
	// nested namespace
	namespace print_methods 
	{
		class myExample1 
		{
			public static void OOPrintWarehouseItem(Warehouse house) 
			{
				var newWarehouseItems = house.findAndReturnItem(101);
				Console.WriteLine(newWarehouseItems.Name);
			}
			public static void Main() 
			{
				Item.PrintItems ();
			}
		}
	} 
}
