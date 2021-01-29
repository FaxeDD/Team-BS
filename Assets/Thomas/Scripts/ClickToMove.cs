using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{

    private NavMeshAgent mNavMeshAgent;
    private Animator mAnimator;

    private bool mRunning = false;

    public int numberOfRooms = 0;

    void Start()
    {
       mAnimator = GetComponent<Animator>();
       mNavMeshAgent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray,out hit,100))
            {
                mNavMeshAgent.destination = hit.point;
            }
        }

        if(mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance)
        {
            mRunning = false;
        }
        else 
        {
            mRunning = true;
        }
        mAnimator.SetBool("running", mRunning);
    }

    void OnTriggerEnter (Collider other )
    {
        if ( other.gameObject.tag == "trigger" )
        {
            Debug.Log("trigger works");
            numberOfRooms += 1;
        }
    }
}
