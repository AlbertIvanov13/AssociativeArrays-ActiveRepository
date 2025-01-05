namespace _8._SoftUniParking
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOfCommands = int.Parse(Console.ReadLine());

			Dictionary<string, Car> cars = new Dictionary<string, Car>();

			for (int i = 0; i < numberOfCommands; i++)
			{
				string[] commands = Console.ReadLine().Split();
				string decision = commands[0];
				if (decision == "register")
				{
					string name = commands[1];
					string license = commands[2];
					if (cars.ContainsKey(name))
					{
						Console.WriteLine($"ERROR: already registered with plate number {license}");
					}
					else
					{
						var car = new Car(name, license);
						cars.Add(name, car);
						Console.WriteLine($"{name} registered {license} successfully");
					}
				}
				else if (decision == "unregister")
				{
					string name = commands[1];
					if (!cars.ContainsKey(name))
					{
                        Console.WriteLine($"ERROR: user {name} not found");
					}
					else
					{
						cars.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
					}
				}
			}

			foreach (Car item in cars.Values)
			{
                Console.WriteLine($"{item.Username} => {item.LicensePlateNumber}");
			}
		}

		public class Car
		{
            public string Username { get; set; }
            public string LicensePlateNumber { get; set; }

			public List<string> Cars { get; set; }
            public Car(string username, string licensePlateNumber)
            {
                Username = username;
				LicensePlateNumber = licensePlateNumber;
            }
        }
	}
}