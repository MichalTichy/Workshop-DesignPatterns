namespace Visitor
{
	public class Program
	{

		static void Main(string[] args)
		{
			// You have decided to create a zoo
			IAnimal lion = new Lion();
			IAnimal elephant = new Elephant();

            // Create logic to feed the animals and provide health care. Each animal have different needs. Use visitor pattern,
            Console.ReadLine();
		}
	}

}