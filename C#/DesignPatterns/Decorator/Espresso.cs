namespace Decorator
{
	public class Espresso : Coffee
	{
		public override string GetDescription()
		{
			return "Espresso";
		}

		public override double GetCost()
		{
			return 40;
		}
	}
}