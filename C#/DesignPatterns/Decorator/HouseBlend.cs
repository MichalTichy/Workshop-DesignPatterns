namespace Decorator
{
	public class HouseBlend : Coffee
	{
		public override string GetDescription()
		{
			return "House Blend Coffee";
		}

		public override double GetCost()
		{
			return 30;
		}
	}
}