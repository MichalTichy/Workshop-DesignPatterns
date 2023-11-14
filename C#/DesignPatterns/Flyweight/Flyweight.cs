namespace Flyweight
{
	public class Flyweight
	{
		public readonly string InstanceName;
		public readonly Guid Id = Guid.NewGuid();

		public Flyweight(string instanceName)
		{
			this.InstanceName = instanceName;
		}
	}
}