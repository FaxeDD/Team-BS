using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ClickToMove : MonoBehaviour
{

    private NavMeshAgent mNavMeshAgent;
    private Animator mAnimator;

    private bool mRunning = false;

    public int numberOfRooms = 0;

    public Image damageSprite;
    public float alphaLevel = 1;

    

    void Start()
    {
       mAnimator = GetComponent<Animator>();
       mNavMeshAgent = GetComponent<NavMeshAgent>(); 

       damageSprite.color = new Color ( 1, 1, 1 , alphaLevel);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray =Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Input.GetMouseButtonDown(1))
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



        

        alphaLevel -= Time.deltaTime * 0.2f;
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
