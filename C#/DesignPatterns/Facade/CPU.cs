namespace Facade
{
	public class CPU
	{
		bool isInitialzied = false;
		public void Init()
		{
			Console.WriteLine("CPU is initialized");
			isInitialzied = true;
		}

		public void ProcessData(byte[] data)
		{
			if (!isInitialzied)
			{
				return;
			}

			Console.WriteLine("Processing data:");

			foreach (var b in data)
			{
				Console.WriteLine(b.ToString("X2"));
			}
		}
	}
}