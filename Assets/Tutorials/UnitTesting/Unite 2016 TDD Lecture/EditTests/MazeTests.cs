using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using PracticeProject.UnitTesting.TDDLecture;
using UnityEngine;
using UnityEngine.TestTools;

[TestFixture]
public class MazeTests
{
    [Test]
    public void DefaultValuesMeakeSenseTest()
    {
        const int mazeLength = 10;
        const int mazeWidth = 6;
        const int numberOfAvailableRewards = 3;

        Maze m1 = new Maze();

        Assert.That(m1.Size.x, Is.EqualTo(mazeLength));
        Assert.That(m1.Size.y, Is.EqualTo(mazeWidth));
        Assert.That(m1.NumberOfAvailableRewards, Is.EqualTo(numberOfAvailableRewards));
    }

    [Test]
    public void DefaultMazeCellIsNotValid() 
    {
        // ARRANGE & ACT
        MazeCell mazeCell = new MazeCell();

        // ASSERT
        Assert.IsFalse(mazeCell.IsValid());
    }

    [Test]
    public void MazeCellHasValidNumberOfWallsTest() 
    {
        // ARRANGE
        MazeCell mazeCell = new MazeCell();

        // ACT & ASSERT
        mazeCell.RemoveWall(WallIndex.NorthWall);
        Assert.IsTrue(mazeCell.IsValid());

        mazeCell.RemoveWall(WallIndex.EastWall);
        Assert.IsTrue(mazeCell.IsValid());

        mazeCell.RemoveWall(WallIndex.SouthWall);
        Assert.IsTrue(mazeCell.IsValid());

        mazeCell.RemoveWall(WallIndex.WestWall);
        Assert.IsTrue(mazeCell.IsValid());
    }
    
    [TestCase(4, 5, 3, WallIndex.NorthWall, true)]
    [TestCase(4, 5, 3, WallIndex.EastWall, false)]
    [TestCase(4, 5, 3, WallIndex.SouthWall, false)]
    [TestCase(4, 5, 3, WallIndex.WestWall, true)]
    [TestCase(4, 5, 8, WallIndex.SouthWall, true)]
    [TestCase(4, 5, 8, WallIndex.NorthWall, false)]
    [TestCase(4, 5, 10, WallIndex.EastWall, false)]
    [TestCase(4, 5, 10, WallIndex.WestWall, false)]
    [TestCase(4, 5, 16, WallIndex.NorthWall, false)]
    [TestCase(4, 5, 16, WallIndex.EastWall, true)]
    [TestCase(4, 5, 16, WallIndex.SouthWall, true)]
    [TestCase(4, 5, 16, WallIndex.WestWall, false)]
    public void IsBorderCellTest(int maxY, int maxX, int cellIndex, WallIndex wallIndex, bool expectedResult)
    {
        // ARRANGE
        MazeShaper shaper = new MazeShaper(maxY, maxX);

        // ACT
        bool result = false;
        if (wallIndex == WallIndex.NorthWall)
        {
            result = shaper.IsNorthBorderCell(cellIndex);
        }

        if (wallIndex == WallIndex.EastWall)
        {
            result = shaper.IsEastBorderCell(cellIndex);
        }

        if (wallIndex == WallIndex.SouthWall)
        {
            result = shaper.IsSouthBorderCell(cellIndex);
        }

        if (wallIndex == WallIndex.WestWall)
        {
            result = shaper.IsWestBorderCell(cellIndex);
        }

        // Assert
        Assert.That(expectedResult, Is.EqualTo(result));
    }

    [TestCase(4, 5, 3, WallIndex.NorthWall, -1)]
    [TestCase(4, 5, 3, WallIndex.EastWall, 7)]
    [TestCase(4, 5, 3, WallIndex.SouthWall, 2)]
    [TestCase(4, 5, 3, WallIndex.WestWall, -1)]
    [TestCase(4, 5, 9, WallIndex.NorthWall, 10)]
    [TestCase(4, 5, 9, WallIndex.EastWall, 13)]
    [TestCase(4, 5, 9, WallIndex.SouthWall, 8)]
    [TestCase(4, 5, 9, WallIndex.WestWall, 5)]
    [TestCase(4, 5, 16, WallIndex.NorthWall, 17)]
    [TestCase(4, 5, 16, WallIndex.EastWall, -1)]
    [TestCase(4, 5, 16, WallIndex.SouthWall, -1)]
    [TestCase(4, 5, 16, WallIndex.WestWall, 12)]
    public void FindAdjacentCellTest(int maxY, int maxX,
                                     int cellIndex, WallIndex wallIndex, int expected)
    {
        // Arrange
        MazeShaper shaper = new MazeShaper(maxY, maxX);

        // Act
        int adjacentResult = shaper.FindAdjacentCellIndex(cellIndex, wallIndex);

        // Assert
        Assert.That(adjacentResult, Is.EqualTo(expected));
    }
}
