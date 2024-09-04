using PracticeProject.UnitTesting.TDDLecture;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PracticeProject.UnitTesting.TDDLecture
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerControlBehaviour : MonoBehaviour
    {
        private Rigidbody _rb;

        [SerializeField] private PlayerStatsBehaviour _playerStats;

        void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        void Update()
        {
            const float speed = 1.5f;

            float thrustX = Input.GetAxis("Horizontal");
            float thrustZ = Input.GetAxis("Vertical");

            Vector3 thrust = new Vector3(thrustX, .0f, thrustZ);

            _rb.AddForce(thrust * speed);
        }

        private void OnTriggerEnter(Collider other)
        {
            DetermineCollisionResult(other);
        }

        private void DetermineCollisionResult(Collider other)
        {
            const int wealthIncrement = 10;
            const int healthIncrement = -5;

            if (other.CompareTag("Reward"))
            {
                other.gameObject.SetActive(false);
                _playerStats.UpdateCurrency(wealthIncrement);
            }

            if (other.gameObject.CompareTag("Hazard"))
            {
                other.gameObject.SetActive(false);
                _playerStats.UpdateHealth(healthIncrement);
            }
        }
    }
}