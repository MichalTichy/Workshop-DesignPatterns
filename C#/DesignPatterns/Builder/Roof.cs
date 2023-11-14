namespace Builder
{
	public record Roof(string Material, string Color)
	{
		public override string ToString()
		{
			return $"Material: {Material}, Color: {Color}";
		}
	}
}