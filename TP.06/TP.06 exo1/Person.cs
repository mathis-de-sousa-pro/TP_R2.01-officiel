using System;

namespace TP._06_exercice_1
{
	public class Person
	{
		private string _lastName;
		private string _firstName;
		
		public Person(string lastName, string firstName)
		{
			_lastName = lastName;
			_firstName = firstName;
		}

		public override string ToString()
		{
			return string.Concat(_firstName, " ", _lastName);
		}
	}
}
