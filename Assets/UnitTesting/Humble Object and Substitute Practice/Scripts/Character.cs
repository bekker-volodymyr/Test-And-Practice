using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PracticeProject.UnitTesting.HOSubPractice
{
    [RequireComponent(typeof(CharacterController))]
    public class Character : MonoBehaviour, ICharacter
    {
        private CharacterController _characterController;

        [Space]
        [SerializeField] private float _speed = 7f;

        [Space]
        [SerializeField] private bool _isPlayer;
        public bool IsPlayer => _isPlayer;

        public int Health { get; set; }

        void Start()
        {
            _characterController = GetComponent<CharacterController>();
        }

        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            _characterController.Move(new Vector3(horizontal, .0f, vertical) * _speed * Time.deltaTime);
        }
    }
}
