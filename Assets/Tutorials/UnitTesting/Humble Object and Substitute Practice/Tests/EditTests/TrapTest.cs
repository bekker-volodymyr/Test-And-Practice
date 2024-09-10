using NSubstitute;
using NUnit.Framework;
using PracticeProject.UnitTesting.HOSubPractice;

public class TrapTest
{
    [TestCase(TrapTarget.Player, true, true)]
    [TestCase(TrapTarget.NPC, true, false)]
    [TestCase(TrapTarget.Player, false, false)]
    [TestCase(TrapTarget.NPC, false, true)]
    public void TrapReducesHealthOnCollision(TrapTarget target, bool isPlayer, bool isReduceExpected)
    {
        // ARRANGE
        Trap trap = new Trap();
        ICharacter character = Substitute.For<ICharacter>();
        character.IsPlayer.Returns(isPlayer);

        // ACT
        float oldHealth = character.Health;
        trap.HandleCollision(character, target);

        // ASSERT
        Assert.IsTrue((character.Health < oldHealth) == isReduceExpected);
    }
}
