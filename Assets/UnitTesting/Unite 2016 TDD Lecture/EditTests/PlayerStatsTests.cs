using NUnit.Framework;
using PracticeProject.UnitTesting.TDDLecture;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

[TestFixture]
public class PlayerStatsTests
{
    [Test]
    public void PlayerBeginsWithMaxHealthTest()
    {
        // ARRANGE
        const int maxHealth = 100;

        // ACT
        PlayerStats playerStats = new PlayerStats();

        // ASSERT
        Assert.That(playerStats.CurrentHealth, Is.EqualTo(maxHealth));
    }

    [Test]
    public void PlayerBeginsWithNoCurrency() 
    {
        // ARRANGE
        const int initialCurrency = 0;

        // ACT
        PlayerStats playerStats = new PlayerStats();

        // ASSERT
        Assert.That(playerStats.CurrentCurrency, Is.EqualTo(initialCurrency));
    }

    [TestCase(20, 100)]
    [TestCase(-20, 80)]
    [TestCase(-120, 0)]
    public void PlayerHealthCanBeUpdated(int deltaHealth, int expectedHealth)
    {
        // ARRANGE
        const int updatedHelath = 50;
        PlayerStats playerStats = new PlayerStats();

        // ACT
        playerStats.UpdateHealth(-25);
        playerStats.UpdateHealth(-25);

        // ASSERT
        Assert.That(playerStats.CurrentHealth, Is.EqualTo(updatedHelath));
    }

    [TestCase(20, 20)]
    [TestCase(-40, 0)]
    public void PlayerCurrencyCanBeUpdated(int deltaCurrency, int expectedCurrency)
    {
        // ARRANGE
        const int updatedCurrency = 50;
        PlayerStats playerStats = new PlayerStats();

        // ACT
        playerStats.UpdateCurrency(25);
        playerStats.UpdateCurrency(25);

        // ASSERT
        Assert.That(playerStats.CurrentCurrency, Is.EqualTo(updatedCurrency));
    }

    #region Tests Before Refactor
    //[TestCase(-120,0)]
    //[TestCase(-150,0)]
    //public void PlayerHelathCannotGoNegativeTest(int deltaHealth, int expectedHealth)
    //{
    //    // ARRANGE
    //    PlayerStats playerStats = new PlayerStats();

    //    // ACT
    //    playerStats.UpdateHealth(deltaHealth);

    //    // ASSERT
    //    Assert.That(playerStats.CurrentHealth, Is.EqualTo(expectedHealth));
    //}

    //[TestCase(20, 100)]
    //[TestCase(50, 100)]
    //public void PlayerHelathCannotExceedMaximumHelathTest(int deltaHealth, int expectedHealth)
    //{
    //    // ARRANGE
    //    PlayerStats playerStats = new PlayerStats();

    //    // ACT
    //    playerStats.UpdateHealth(deltaHealth);

    //    // ASSERT
    //    Assert.That(playerStats.CurrentHealth, Is.EqualTo(expectedHealth));
    //}
    #endregion

}
