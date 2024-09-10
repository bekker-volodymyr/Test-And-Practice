using UnityEditor;
using UnityEngine;

namespace PracticeProject.UnitTesting.PMTestingPractice
{
    public class ObjectSpawner : MonoBehaviour
    {
        [Space] 
        [SerializeField] private Object _objPrefab;
        [SerializeField] private float _spawnRate;
        [SerializeField] private int _spawnRadius;

        private float _timeSinceLastSpawn;
        private Circle _circle;

        public System.Random Random { get; set; }

        private void Update()
        {
            if(_circle == null)
            {
                _circle = new Circle(_spawnRadius);
            }

            if (Random is null)
            {
                Random = new System.Random();
            }

            if (_timeSinceLastSpawn >= _spawnRate)
            {
                SpawnObject();
            }

            _timeSinceLastSpawn += Time.deltaTime;
        }

        private void SpawnObject()
        {
            var obj = PrefabUtility.InstantiatePrefab(_objPrefab) as GameObject;

            var degrees = Random.Next(0, 361);

            obj.transform.position = _circle.GetPositionOnCircleBoundaries(degrees);

            _timeSinceLastSpawn = 0;
        }

        public void Construct(Object objPrefab, int spawnRate, int spawnRadius)
        {
            _objPrefab = objPrefab;
            _spawnRate = spawnRate;
            _circle = new Circle(spawnRadius);
        }
    }
}