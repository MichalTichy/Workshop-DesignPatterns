namespace Composite
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Todo the contact database is getting big. We should group the contacts with same company to their own group. Use composite pattern.
			var contactDatabase = new ContactDatabase();
			foreach (var contact in contactDatabase.Contacts)
			{
				contact.SendEmail("We have scraped your info from the web. Have fun with the spam!");
			}
		}
	}
}