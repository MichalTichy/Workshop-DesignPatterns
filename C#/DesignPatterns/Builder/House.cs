namespace Builder
{
	public record House(IList<Room> Rooms, Roof Roof)
	{
		public void DescribeHouse()
		{
			Console.WriteLine("This is a house with the following rooms:");
			foreach (var room in Rooms)
			{
				Console.WriteLine(room.ToString());
			}

			Console.WriteLine($"And the roof is: {Roof.ToString()}");
		}
	};
}