using System;
namespace HelloWorld
{
	public class Venue
	{
		public string Name;
		public Venue()
		{
		}

		public void Announce()
		{
			Console.WriteLine(Name + " will have several bands playing tonight!");
		}
	}
}
