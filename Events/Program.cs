using System;

namespace Events
{
	internal class Program
	{
		private static void Main()
		{
			PersonModel person = new PersonModel("Tim", "Corey");
			person.LastNameChanged += Person_LastNameChanged;

			Console.WriteLine(person.FullName);

			person.LastName = "Storm";

			Console.WriteLine(person.FullName);

			_ = Console.ReadLine();
		}

		private static void Person_LastNameChanged(object sender, string e)
		{
			PersonModel model = (PersonModel)sender;

			Console.WriteLine();
			Console.WriteLine($"{model.FullName}'s last name has changed: {e}");
			Console.WriteLine();
		}
	}
}
