using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAScript : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    Transform player;
    private float distance;
    public float HowClose;
    public Animator animator;

    public AudioSource detectionSound;
    
    private bool EnemiSee = false;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent=this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        detectionSound = GameObject.Find("enemyDetection").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.position,transform.position);
       
       if(distance <= HowClose)
        {
            detectionSound.Play();
            agent.SetDestination(player.position);
            EnemiSee = true;
        }

        if(distance <= 1.5f)
        {

        }
        animator.SetBool("ENEMIMOVE",EnemiSee);

    }
}
