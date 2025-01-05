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

				}
				else if (decision == "unregister")
				{
					string name = commands[1];
				}
			}
		}

		public class Car
		{
            public string Username { get; set; }
            public string LicensePlateNumber { get; set; }

            public Car(string username, string licensePlateNumber)
            {
                Username = username;
				LicensePlateNumber = licensePlateNumber;
            }
        }
	}
}
