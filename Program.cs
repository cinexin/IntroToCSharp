using System;

namespace HelloWorld
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			string venue = "C's Blues";
			Console.WriteLine("How many people are in your band?");
			string bandArgument = Console.ReadLine();
			int bands;
			if (int.TryParse(bandArgument, out bands) == true) {
              Console.WriteLine(venue + " will have " + bands + " bands performing tonight!");
        	}
			 else {
            Console.WriteLine("We were unable to determine the number of bands performing tonight, try again.");
        	}

			if (bands == 0)
			{
				Console.WriteLine("There will be no performances tonight.");
			}
			else if (bands == 1)
			{
				Console.WriteLine("It's going to be a fantastic show tonight!");
			}
			else
			{
				Console.WriteLine("There will be plenty of thrilling performances to see tonight!");
			}

			Console.WriteLine(Announce(venue));
			SelfAnnounce(venue);


			Venue venueClass = new Venue();
			venueClass.Name = "The Jazz Hut";
			venueClass.Announce();


			venueClass.AddBand("Nirvana");
			venueClass.Announce();

			Console.ReadLine();
		}

		static string Announce(string venue)
		{
			return venue + " will have bands performing tonight.";
		}

		static void SelfAnnounce(string venue)
		{
			Console.WriteLine ("hey yo!" + venue + " will have bands performing tonight.");
		}
	}
}
