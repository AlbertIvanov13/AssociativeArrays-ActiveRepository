namespace _9._Courses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Course> courses = new Dictionary<string, Course>();

			while (true)
			{
				string[] arguments = Console.ReadLine().Split(":");
				string courseName = arguments[0];
				if (courseName == "end")
				{
					break;
				}
				string userName = arguments[1];

				if (!courses.ContainsKey(courseName))
				{
					var course = new Course(courseName);
					courses.Add(courseName, course);
					course.AddUser(userName);
				}
				else
				{
					courses[courseName].AddUser(userName);
				}
			}

			foreach (var course in courses.Values)
			{
                Console.WriteLine($"{course.Name.Trim()}: {course.RegisteredUsers.Count}");
				foreach (var item in course.RegisteredUsers)
				{
                    Console.WriteLine($"--{item}");
				}
			}
		}

		public class Course
		{
			public string Name { get; set; }
			public List<string> RegisteredUsers { get; set; }

			public Course(string name)
			{
				Name = name;
				RegisteredUsers = new List<string>();
			}

			public void AddUser(string name)
			{
				RegisteredUsers.Add(name);
			}
		}
	}
}