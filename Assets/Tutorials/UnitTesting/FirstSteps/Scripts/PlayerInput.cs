using UnityEngine;

namespace PracticeProject.UnitTesting
{
    public class PlayerInput : IPlayerInput
    {
        public float Vertical => Input.GetAxis("Vertical");
    }
}