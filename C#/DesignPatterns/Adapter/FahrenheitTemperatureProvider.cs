namespace Adapter
{
	public class FahrenheitTemperatureProvider : ITemperatureProvider
	{
		public double GetTemperature()
		{
			return Random.Shared.Next(-4,104); // return temperature in Fahrenheit
		}
	}
}