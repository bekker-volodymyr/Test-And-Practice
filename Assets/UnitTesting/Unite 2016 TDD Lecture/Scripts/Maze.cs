using System.Numerics;
using UnityEngine;

namespace PracticeProject.UnitTesting.TDDLecture
{
    public class Maze
    {
        public Vector2Int Size { get; set; }
        public int NumberOfAvailableRewards { get; set; }

        public Maze() 
        {
            Size = new Vector2Int(10, 6);
            NumberOfAvailableRewards = 3;
        }
    }
}