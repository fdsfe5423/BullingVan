using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dog : MonoBehaviour
{
    public NavMeshAgent _agent;
    public List<GameObject> points = new List<GameObject>();


    private void Update()
    {
        if (_agent.remainingDistance < 0.01)
        {
            _agent.SetDestination(points[Random.Range(0, points.Count)].transform.position);
        }
    }
}
