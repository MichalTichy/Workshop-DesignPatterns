namespace Observer
{
	public class MagicNumberGenerator
	{
		public MagicNumberGenerator()
		{
			Task.Run(async () =>
			{
				while (true)
				{
					await PerformDifficultCalculation();
				}
			});
		}

		private async Task PerformDifficultCalculation()
		{
			await Task.Delay(1000);

			//I have result, but I don't wanna share it!
			var result = Random.Shared.Next();
		}

	}
}