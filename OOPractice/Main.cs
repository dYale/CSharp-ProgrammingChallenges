using System;

namespace OOPractice
{
	// nested namespace
	namespace print_methods 
	{
		class myExample1 
		{
			public static void OOPrint(Warehouse house) 
			{
				var newWarehouseItems = house.findAndReturnItem(101);
				Console.WriteLine(newWarehouseItems.Name);
			}
			public static void Main() 
			{
				var newWarehouse = new Warehouse ("Newark", 101);
				OOPrint(newWarehouse);
			}
		}
	} 
}
