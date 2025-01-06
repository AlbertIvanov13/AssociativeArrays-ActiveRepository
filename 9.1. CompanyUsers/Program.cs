namespace _9._1._CompanyUsers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Company> companies = new Dictionary<string, Company>();

			while (true)
			{
				string[] arguments = Console.ReadLine().Split("->");
				string companyName = arguments[0];
				if (companyName == "End")
				{
					break;
				}
				string employeeId = arguments[1];

				var company = new Company();
				if (!companies.ContainsKey(companyName))
				{
					companies.Add(companyName, company);
					company.AddEmployeeId(employeeId);
				}
                else
                {
					if (companies[companyName].EmployeesIds.Contains(employeeId))
					{
						continue;
					}
					else
					{
						companies[companyName].AddEmployeeId(employeeId);
					}
                }
            }

			foreach (var newItem in companies)
			{
                Console.WriteLine(newItem.Key);
				foreach (var item in newItem.Value.EmployeesIds)
				{
                    Console.WriteLine($"--{item}");
				}				
			}
		}

		public class Company
		{
            public List<string> EmployeesIds { get; set; }

            public Company()
            {
				EmployeesIds = new List<string>();
            }

			public void AddEmployeeId(string employeeId)
			{
				EmployeesIds.Add(employeeId);
			}
        }
	}
}