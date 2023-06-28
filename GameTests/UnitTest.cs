
using System;

namespace Game;

public class UnitTest1
{
    [Fact]
    public void TestClassFighter()
    {
		Fighter.ResetCount();
		var fighter = new Fighter("John", "Doe",2001, Level.Easy);
		var fullName = fighter.GetFullName();
		// Assert
		Assert.Equal("John Doe", fullName);
		Assert.Equal(22, fighter.GetAge());
    }

	[Fact]
	public void TestClassCountFighter()
	{
		Fighter.ResetCount();
		var fighter1 = new Fighter("John", "Doe", 2005, Level.Easy);
		var fighter2 = new Fighter("Ninja", "Dragon", 2004, Level.Medium);
		var fighter3 = new Fighter("Shadow", "Fighter", 2001, Level.Hard);
		var fighter4 = new Fighter("Young", "Peter", 1998, Level.Easy);
		Assert.Equal(4, Fighter.GetCount());
	}


	[Fact]
	public void TestClassInitialLiveCount()
	{
		Fighter.ResetCount();
		var fighter = new Fighter("John", "Doe", 2001,Level.Easy);
		Assert.Equal(100, fighter.GetLiveCount());
	}
}