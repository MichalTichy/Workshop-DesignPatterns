namespace Facade
{
	public class Memory
	{
		private Dictionary<long, byte[]> memory = new Dictionary<long, byte[]>();

		public void Load(long position, byte[] data)
		{
			Console.WriteLine($"Memory starts loading at position {position} with data length of {data.Length}.");
			memory[position] = data;
		}

		public byte[]? GetData(long position)
		{
			if (memory.TryGetValue(position, out var data))
			{
				Console.WriteLine($"Data retrieved from memory at position {position}.");
				return data;
			}

			Console.WriteLine($"No data available in memory at position {position}.");
			return null;
		}

		public void Clear()
		{
			memory.Clear();
		}
	}
}