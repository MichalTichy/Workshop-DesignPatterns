namespace Adapter
{
	class WeatherReporter
	{
		private readonly ICelsiusTemperatureProvider temperatureProvider;

		public WeatherReporter(ICelsiusTemperatureProvider temperatureProvider)
		{
			this.temperatureProvider = temperatureProvider;
		}

		public void ReportTemperature()
		{
			var temp = temperatureProvider.GetTemperatureInCelsius();

			switch (temp)
			{
				case < -10:
					Console.WriteLine("It's so cold, polar bears are wearing scarves!");
					break;
				case < 0:
					Console.WriteLine("It's chilly out there, time to slide on ice!");
					break;
				case < 20:
					Console.WriteLine("You might want a jacket, it's sweater weather!");
					break;
				case < 30:
					Console.WriteLine("Perfect weather for a stroll, unless you’re a snowman!");
					break;
				default:
					Console.WriteLine("It's hotter than a dragon's breath out there, perfect for a barbecue... unless the barbecue is you!");
					break;
			}
		}
	}
}