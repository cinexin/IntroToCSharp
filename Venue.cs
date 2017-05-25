using System;
using System.Collections.Generic;

namespace HelloWorld
{
	public class Venue
	{

		/*
         * Create a public array of type Band[] called Bands 
         * and instantiate it to contain 2 new Band objects.
		 */

		public string Name;
		public List<Band> Bands = new List<Band>();

		public Venue()
		{
		}

		public void AddBand(string name)
		{
			Band band = new Band();
			band.Name = name;
			Bands.Add(band);		}

		public void AddBand(string[] bandNames)
		{
			foreach (var bandName in bandNames)
			{
				AddBand(bandName);
			}
		}

		public void Announce()
		{
			Console.WriteLine(Name + " will have several bands playing tonight!");
			foreach (var band in Bands)
			{
				band.Announce();
			}
		}
	}
}
