namespace Observer
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			_=new MagicNumberGenerator();

			//Magic number Believer and Denier would like to comment on each magic number generated. Use observer pattern


			while (true)
			{
				await Task.Delay(100);
			}
		}
	}
}