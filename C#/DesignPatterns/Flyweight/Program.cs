namespace Flyweight
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Each instance with identical name should be the same
			for (int i = 0; i < 10; i++)
			{
				var instanceName = GetInstanceName();
				var instance = new Flyweight(instanceName);
				Console.WriteLine($"Name: {instance.InstanceName} - {instance.Id}");
			}
		}

		private static string GetInstanceName()
		{
			return Random.Shared.Next(0, 2) == 0 ? "Instance 1" : "Instance 2";
		}
	}
}