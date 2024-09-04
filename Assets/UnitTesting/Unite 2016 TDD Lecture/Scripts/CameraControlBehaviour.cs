using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PracticeProject.UnitTesting.TDDLecture
{
    public class CameraControlBehaviour : MonoBehaviour
    {
        [Space]
        [SerializeField] private GameObject _player;

        [Space]
        [SerializeField] private float _playerOffset = 30.0f;

        private Vector3 _offset;

        void Start()
        {
            _offset = transform.position - _player.transform.position;
            _offset += new Vector3(0.0f, _playerOffset, 0.0f);
        }

        void LateUpdate()
        {
            transform.position = _player.transform.position + _offset;
            transform.LookAt(_player.transform);
        }
    }
}
