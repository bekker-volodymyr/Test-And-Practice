using UnityEngine;

namespace PracticeProject.UnitTesting.TDDLecture
{
    public class MazeWallBehaviour: MonoBehaviour
    {
        public bool IsOuterBorderWall { get; set; }

        public void RemoveWall()
        {
            if (!IsOuterBorderWall)
            {
                this.gameObject.SetActive(false);
            }
        }

        public void AddWall()
        {
            this.gameObject.SetActive(true);
        }
    }
}
