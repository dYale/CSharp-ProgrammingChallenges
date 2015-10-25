using System;
namespace OOPractice
{
	class Warehouse
	{
		public int ID{ get; set;}
		public string warehouseName { get; set;}

		public Warehouse(string Name, int ID){
			this.ID = ID;
			warehouseName = Name;
		}

		public Item findAndReturnItem(int itemID)
		{
			Item returnItem = new Item (){ ID = itemID, Name = "Game of Thrones Season 1 Boxset"};
			return returnItem;
		}
	}
}

