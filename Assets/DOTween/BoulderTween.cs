using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderTween : MonoBehaviour
{
    [SerializeField] private List<Waypoint> _waypoints = new List<Waypoint>();

    private async void Start()
    {
        foreach(var waypoint in _waypoints)
        {
            Sequence seq = DOTween.Sequence();
            
            seq.Join(transform.DOMove(waypoint.position + transform.position, waypoint.timeToWaypoint).SetEase(Ease.Linear));
            seq.Join(transform.DOLocalRotate(waypoint.rotationAxis * 150 * waypoint.timeToWaypoint, waypoint.timeToWaypoint, RotateMode.FastBeyond360).SetEase(Ease.Linear));

            await seq.AsyncWaitForCompletion();
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
     
        foreach(Waypoint waypoint in _waypoints)
        {
            Gizmos.DrawSphere(waypoint.position + transform.position, 0.3f);
        }
    }

    [System.Serializable]
    class Waypoint
    {
        public Vector3 position;
        public Vector3 rotationAxis;
        public float timeToWaypoint;
    }
}
