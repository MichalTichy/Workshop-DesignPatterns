namespace Composite
{
	public class Contact
	{
		
		public string Email { get; }
		public string? Company { get; }

		public Contact(string email, string? company)
		{
			this.Email = email;
			Company = company;
		}

		public void SendEmail(string message)
		{
			Console.WriteLine($"Sending Email to single recipient: {this.Email}, Message: {message}");
		}
	}
}