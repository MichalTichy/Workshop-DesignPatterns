namespace Decorator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Coffee myCoffee1 = new Espresso();
			Coffee myCoffee2 = new HouseBlend();

			//People are weird, some even like to put milk and sugar to their coffee!
			//We need to support everybody. Add support for adding milk (+10Czk) and sugar(price*2) to coffee.


			Console.WriteLine($"{myCoffee1.GetCost()} - {myCoffee1.GetDescription()}");
			Console.WriteLine($"{myCoffee2.GetCost()} - {myCoffee2.GetDescription()}");
			Console.WriteLine($"Total Cost in CZK: {myCoffee1.GetCost() + myCoffee2.GetCost()}");
		}
	}
}