namespace Iterator
{
	using System.Collections;

	public class Program
	{
		static void Main(string[] args)
		{
			Book[] books = new Book[]
			{
				new Book { Title = "Book 1" },
				new Book { Title = "Book 2" },
				new Book { Title = "Book 3" }
			};

			Library library = new Library(books);


			//todo implement iterator
			//foreach (Book book in library)
			//{
			//	System.Console.WriteLine(book.Title);
			//}
		}
	}
}