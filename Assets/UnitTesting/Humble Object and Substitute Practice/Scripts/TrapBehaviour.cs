using UnityEngine;

namespace PracticeProject.UnitTesting.HOSubPractice
{
    public class TrapBehaviour: MonoBehaviour
    {
        private Trap _trap;

        [SerializeField] private TrapTarget _target;

        private void Awake()
        {
            _trap = new Trap();
        }

        private void OnTriggerEnter(Collider other)
        {
            var character = other.gameObject.GetComponent<ICharacter>();
            Debug.Log($"{character}");
            _trap.HandleCollision(character, _target);
        }
    }
}