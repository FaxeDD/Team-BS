using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAScript : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    public Transform Ball;
    public Transform goal;
    // Start is called before the first frame update
    void Start()
    {
        agent=this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.speed = 14f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ballToGoal = goal.position - Ball.position;

        agent.SetDestination(Ball.position);
    }
}
