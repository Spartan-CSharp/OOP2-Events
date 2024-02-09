using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
	public class PersonModel
	{
		public event EventHandler<string> LastNameChanged;

		private string _firstName;

		public string FirstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				_firstName = value;
			}
		}

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
			_firstName = firstName;
			_lastName = lastName;
		}
	}
}
