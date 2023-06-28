
namespace Game
{
	public class Fighter : Person {

		private int _attackPower;
		private int _defensePower;
		public int _liveCount = 100;
		private bool _defenseReady = true;
		public Fighter(string firstName, string lastName, int birthYear, Level level) : base(firstName, lastName, birthYear)
		{
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

			if (this == fighter){
				throw new System.Exception("You can't attack yourself");
			}

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
	}
}