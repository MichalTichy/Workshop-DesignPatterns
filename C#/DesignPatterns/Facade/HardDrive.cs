namespace Facade
{
	public class HardDrive
	{
		public byte[] Read(long position)
		{ 
			//generate random data
			var data = new byte[10];
			Random.Shared.NextBytes(data);
			return data;
		}
	}
}