namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			// add different sorts (by average, last name and than first name,....)
			StudentList studentRecords = new StudentList();

			studentRecords.Add(new Student("Samuel","Lorenc",2.4));
			studentRecords.Add(new Student("Jimmy", "Adams",1.2));
			studentRecords.Add(new Student("Sandra", "Smith",4.2));
			studentRecords.Add(new Student("Vivek", "Franc",2.8));
			studentRecords.Add(new Student("Anna", "Ohm",1.4));

			studentRecords.Sort();
			
			Console.ReadKey();
		}
	}

}