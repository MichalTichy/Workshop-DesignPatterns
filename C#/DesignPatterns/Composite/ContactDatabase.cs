namespace Composite
{
	public class ContactDatabase
	{
		public ICollection<Contact> Contacts { get; }
		public ContactDatabase()
		{
			Contacts = new List<Contact>()
			{
				new Contact("john.doe@company1.com", "Company1"),
				new Contact("jane.smith@company2.com", "Company2"),
				new Contact("robert.johnson@company3.com", "Company3"),
				new Contact("james.brown@company1.com", "Company1"),
				new Contact("michael.jordan@company2.com", "Company2"),
				new Contact("linda.jackson@company3.com", "Company3"),
				new Contact("david.jones@company1.com", "Company1"),
				new Contact("jennifer.miller@company2.com", "Company2"),
				new Contact("mary.johnson@company3.com", "Company3"),
				new Contact("richard.moore@company1.com", "Company1"),
				new Contact("susan.taylor@company2.com", "Company2"),
				new Contact("paul.anderson@company3.com", "Company3"),
				new Contact("sarah.wilson@company1.com", "Company1"),
				new Contact("william.clark@company2.com", "Company2"),
				new Contact("patricia.hall@company3.com", "Company3"),
				new Contact("dorothy.martin@company1.com", "Company1"),
				new Contact("joseph.thompson@company2.com", "Company2"),
				new Contact("thomas.miller@company3.com", "Company3"),
				new Contact("charles.jackson@company1.com", "Company1"),
				new Contact("barbara.white@company2.com", "Company2"),
				new Contact("mike.davis@none.com", null),
				new Contact("nancy.brown@none.com", null),
				new Contact("gary.wilson@none.com", null),
				new Contact("elizabeth.taylor@none.com", null),
				new Contact("mark.harris@none.com", null)
			};
		}
		
	}
}