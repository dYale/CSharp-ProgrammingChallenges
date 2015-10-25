using System;
using System.Collections.Generic;
namespace OOPractice
{
	public class Item
	{
		public int ID { get; set;}
		public string Name { get; set;}
		public virtual void Purchase()
		{
			Console.WriteLine("Running Print of:{0}",Name);
		}

		public static List<Item> GetItems(int numToGet)
		{
			var random = new Random ();
			var newList = new List<Item> ();
			Item newItem;
			for (var i = 0; i < numToGet; i++)
			{
				newItem = new Item(){ ID = random.Next (), Name = "Me"};
				newList.Add (newItem);
			}
			return newList;
		}

		public static void PrintItems()
		{
			Item comic = new Comics ();
			Comics newComic = comic as Comics;
			newComic.Name = "Avengers";
			comic.Purchase ();
			newComic.Purchase ();

			var g = Item.GetItems (10);
			foreach(var s in g)
			{
				Console.WriteLine (s.ID + "   " + s.Name);
			}
		}
	}

	public class Shovels : Item
	{
		public string SerialNumber { get; set;}
	}

	public class Books : Item
	{
		public string ISBN { get; set;}
	}


	public class Comics : Books
	{
		string Publisher { get; set;}
		bool Colored {get; set;}
		public void Purchase()
		{
			base.Purchase ();
			Console.WriteLine("Running Print of:{0}", Colored);
		}

	}

	public class Biographies : Books
	{
		string Description {get;set;}
		
	}

}

