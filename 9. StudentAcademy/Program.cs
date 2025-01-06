namespace _9._StudentAcademy
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int pairOfRows = int.Parse(Console.ReadLine());

			Dictionary<string, Student> students = new Dictionary<string, Student>();

			for (int i = 0; i < pairOfRows; i++)
			{
				string studentName = Console.ReadLine();
				double grade = double.Parse(Console.ReadLine());

				var newStudent = new Student(studentName);

				if (!students.ContainsKey(studentName))
				{
					newStudent.AddGrade(grade);
					students.Add(studentName, newStudent);
				}
                else
                {
					students[studentName].AddGrade(grade);
				}
            }

			var filteredGrades = students.Where(g => g.Value.Grades.Average() >= 4.50).ToList();
			foreach (var grade in filteredGrades)
			{
                Console.WriteLine(grade.Value);
			}
		}

		public class Student
		{
            public string Name { get; set; }
            public List<double> Grades { get; set; }

            public Student(string name)
            {
                Name = name;
				Grades = new List<double>();
            }

			public void AddGrade(double grade)
			{
				Grades.Add(grade);
			}

            public override string ToString()
			{
				return $"{Name} -> {Grades.Average():f2}";
			}
		}
	}
}