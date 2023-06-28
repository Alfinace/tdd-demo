
namespace Game
{
	public class Fighter : Person{

		private string _firstName;
		private string _lastName;
		private int _birthYear;
		private static int _count = 0;
		private int _liveCount = 100;

		public Fighter(string firstName, string lastName, int birthYear, Level level) : base(firstName, lastName, birthYear)
		{
			
		}

		public int GetLiveCount()
		{
			return _liveCount;
		}
	}
}