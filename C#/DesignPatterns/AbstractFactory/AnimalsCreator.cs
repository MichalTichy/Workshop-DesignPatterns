using AbstractFactory.animals;

namespace AbstractFactory
{
    public class AnimalsCreator
	{
		public IEnumerable<IAnimal> CreateAnimals()
		{
			while (true)
			{
				var isCarnivore = Random.Shared.Next(0, 5) == 0;
				if (isCarnivore)
				{
					yield return new Wolf();
				}
				else
				{
					yield return new Bison();
				}
			}
		}
	}
}