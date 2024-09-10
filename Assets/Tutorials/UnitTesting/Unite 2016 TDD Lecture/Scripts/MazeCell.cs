using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PracticeProject.UnitTesting.TDDLecture
{
    public class MazeCell
    {
        public List<WallIndex> Walls { get; set; }

        public bool HasReward { get; set; }
        public bool HasHazard { get; set; }

        public MazeCell()
        {
            Walls = new List<WallIndex>() { WallIndex.NorthWall, WallIndex.EastWall, WallIndex.SouthWall, WallIndex.WestWall };
        }

        public void RemoveWall(WallIndex wallIndex)
        {
            Walls.Remove(wallIndex);
        }

        public bool IsValid()
        {
            if (Walls.Count >= 0 && Walls.Count < 4)
            {
                return true;
            }

            return false;
        }
    }
}
