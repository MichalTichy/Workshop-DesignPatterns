namespace Builder
{
	public record Room(string Type, int Size)
	{
		public override string ToString()
		{
			return $"Type: {Type}, Size: {Size} square meters";
		}
	}
}