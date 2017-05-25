using System;
namespace HelloWorld
{
	public class Band
	{
		public string Name;

		public void Announce()
		{
			Console.WriteLine("Welcome " + Name + " to the stage!");
		}

		public Band()
		{
		}
	}
}
