using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PracticeProject.UnitTesting.PMTestingPractice
{
    public class Circle
    {
        private int _spawnRadius;

        public Circle(int radius)
        {
            _spawnRadius = radius;
        }

        public Vector3 GetPositionOnCircleBoundaries(int degrees)
        {
            return new Vector3(CalculateXCoord(degrees), 0f, CalculateYCoord(degrees));
        }

        private float CalculateYCoord(int degrees)
        {
            var y = _spawnRadius * Mathf.Sin(degrees * Mathf.Deg2Rad);
            if (Mathf.Abs(y) < 0.01f) y = 0;
            return y;
        }

        private float CalculateXCoord(int degrees)
        {
            var x = _spawnRadius * Mathf.Cos(degrees * Mathf.Deg2Rad);
            if (Mathf.Abs(x) < 0.01f) x = 0;
            return x;
        }
    }

}
