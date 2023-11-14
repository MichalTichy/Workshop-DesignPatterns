namespace AbstractFactory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//All currently supported animals are from America, add support to specify other continents during AnimalsCreator initialization. Use abstract factory.
			var animalCreator = new AnimalsCreator();
			foreach (var animal in animalCreator.CreateAnimals().Take(10))
			{
				Console.WriteLine($"{animal.GetType().Name} - {animal.Food}");
			}
		}
	}
}