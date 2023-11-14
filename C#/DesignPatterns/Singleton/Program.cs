namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
		//Todo each singleton instance should be the same
	    for (int i = 0; i < 10; i++)
	    {
		    var instance = new Singleton();
			Console.WriteLine(instance.Id);
	    }
    }

}