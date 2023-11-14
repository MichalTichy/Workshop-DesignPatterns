namespace Strategy
{
	public class StudentList
	{
		private List<Student> list = new();

		public void Add(Student student)
		{
			list.Add(student);
		}

		public void Sort()
		{
			list = list.OrderBy(t=>t.LastName).ToList();
		}
	}
}