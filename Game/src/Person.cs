
using System;
namespace Game
{
	public class Person
	{
		private string _firstName;
		private string _lastName;
		private int _birthYear;
		private static int _count = 0;

		public Person(string firstName, string lastName, int birthYear)
		{
			_firstName = firstName;
			_lastName = lastName;
			_birthYear = birthYear;
			_count++;
		}

		public string GetFullName()
		{
			return $"{_lastName}";
		}

		public int GetAge()
		{
			return DateTime.Now.Year - _birthYear;
		}

		public static int GetCount()
		{
			return _count;
		}

		public static void ResetCount()
		{
			_count = 0;
		}
	}
}