using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PracticeProject.UnitTesting.TDDLecture
{
    public class MazeCellBehaviour : MonoBehaviour
    {
        [SerializeField]
        List<MazeWallBehaviour> _mazeWalls;

        MazeCell _mazeCell;

        void Awake()
        {
            // TODO: Make rewards and hazards random.
            _mazeCell = new MazeCell();
            _mazeCell.HasHazard = true;
            _mazeCell.HasReward = true;
        }

        public void SetOuterWallAsBorder(WallIndex wallIndex)
        {
            if ((int)wallIndex >= 0 && (int)wallIndex < _mazeWalls.Count)
            {
                _mazeWalls[(int)wallIndex].IsOuterBorderWall = true;
            }
        }

        public void RemoveWall(WallIndex wallIndex)
        {
            if ((int)wallIndex >= 0 && (int)wallIndex < _mazeWalls.Count)
            {
                if (!_mazeWalls[(int)wallIndex].IsOuterBorderWall)
                {
                    _mazeCell.RemoveWall(wallIndex);
                    _mazeWalls[(int)wallIndex].RemoveWall();
                    _mazeWalls[(int)wallIndex].gameObject.SetActive(false);
                }
            }
        }

        public bool DoesWallExist(WallIndex wallIndex)
        {
            if ((int)wallIndex >= 0 && (int)wallIndex < _mazeWalls.Count)
            {
                return _mazeWalls[(int)wallIndex].gameObject.activeSelf;
            }

            return false;
        }
    }
}