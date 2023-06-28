using System;
using System.Reflection;
namespace Game;

public class FightTest
{
	[Fact]

	public void TestClassInitialStateFighter()
	{
		var f1 = new Fighter("John", "Doe", 2001,Level.Easy);
		var f2 = new Fighter("Ninja", "Dragon", 2004,Level.Medium);
		var f3 = new Fighter("Ninja", "Dragon", 2004,Level.Hard);
		Assert.Equal(10, f1.GetDefensePower());
		Assert.Equal(10, f1.GetAttackPower());
		Assert.Equal(20, f2.GetDefensePower());
		Assert.Equal(20, f2.GetAttackPower());
		Assert.Equal(30, f3.GetDefensePower());
		Assert.Equal(30, f3.GetAttackPower());
	}

	[Fact]

	public void TestLiveCountInRound()
	{
		var f1 = new Fighter("John", "Doe", 2001,Level.Easy);
		var f2 = new Fighter("Ninja", "Dragon", 2004,Level.Medium); 


		f2.setDefenseState(false);
		f1.Attack(ref f2);
		f2.Attack(ref f1);
		f1.Attack(ref f2);
		f2.Attack(ref f1);
		f1.Attack(ref f2);
		f1.Attack(ref f2);
		f1.setDefenseState(false);
		f2.setDefenseState(true);
		f1.Attack(ref f2);
		f2.Attack(ref f1);

		Assert.Equal(60, f2.GetLiveCount());
	}

	[Fact]
	public void AttackSelfShouldByExeption()
	{
		var f1 = new Fighter("John", "Doe", 2001,Level.Easy);
		Assert.Throws<Exception>(() => f1.Attack(ref f1));
	}
}
