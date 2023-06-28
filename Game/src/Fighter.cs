
using System;
namespace Game
{
	public class Fighter {

		private string _firstName;
		private string _lastName;
		private int _birthYear;
		private static int _count = 0;
		private int _liveCount = 100;

		public Fighter(string firstName, string lastName, int birthYear, Level level) 
		{
			throw new NotImplementedException("Not implemented");
		}

		public string GetFullName()
		{
			throw new NotImplementedException("Not implemented.");
		}

		public int GetAge()
		{
			throw new NotImplementedException("Not implemented.");
		}

		public static int GetCount()
		{
			throw new NotImplementedException("Not implemented.");
		}

		public static void ResetCount()
		{
			throw new NotImplementedException("Not implemented.");
		}

		public int GetLiveCount()
		{
			throw new NotImplementedException("Not implemented.");
		}
	}
}