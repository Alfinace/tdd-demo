
namespace Game
{
	public class Fighter {

		private string _firstName;
		private string _lastName;
		private int _birthYear;
		private static int _count = 0;


		private int _attackPower;
		private int _defensePower;
		public int _liveCount = 100;
		private bool _defenseReady = true;
		public Fighter(string firstName, string lastName, int birthYear, Level level) 
		{
			_firstName = firstName;
			_lastName = lastName;
			_birthYear = birthYear;
			_count++;
		
			if (level == Level.Easy)
			{
				_attackPower = 10;
				_defensePower = 10;
			}
			else if (level == Level.Medium)
			{
				_attackPower = 20;
				_defensePower = 20;
			}
			else if (level == Level.Hard)
			{
				_attackPower = 30;
				_defensePower = 30;
			}
		}

		public void setDefenseState(bool state){
			_defenseReady = state;
		}

		public void setAttackPower(int attackPower){
			_attackPower = attackPower;
		}

		public void setLiveCount(int liveCount){
			_liveCount = liveCount;
			if (_liveCount <= 0){
				_attackPower = 0;
				_defensePower = 0;
			}
		}

		public void Attack(ref Fighter fighter){
			if (fighter._defenseReady == false){
				fighter.setLiveCount(fighter._liveCount - _attackPower);
			}
		}

		public int GetAttackPower(){
			return _attackPower;
		}

		public int GetDefensePower(){
			return _defensePower;
		}

		public int GetLiveCount(){
			return _liveCount;
		}


		public string GetFullName()
		{
			return $"{_firstName} {_lastName}";
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