using System;

namespace Events
{
	public class PersonModel
	{
		public event EventHandler<string> LastNameChanged;

		public string FirstName { get; set; }

		private string _lastName;

		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				LastNameChanged?.Invoke(this, $"Last Name has been changed from {_lastName} to {value}.");
				_lastName = value;
			}
		}

		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}

		public PersonModel(string firstName, string lastName)
		{
			FirstName = firstName;
			_lastName = lastName;
		}
	}
}
