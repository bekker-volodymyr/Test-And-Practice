using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoToDestination : MonoBehaviour
{
    public Transform destination;

    private NavMeshAgent navMeshAgent;
    // private Animator animator;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

        navMeshAgent.SetDestination(destination.position);
    }

    // Update is called once per frame
    void Update()
    {
        // float speed = navMeshAgent.velocity.magnitude / navMeshAgent.speed;
    }
}
