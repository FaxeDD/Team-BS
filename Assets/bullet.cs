using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    private Shooting shooting;
    private ShootBullet shootBullet;

    public float lifetime = 2.0f;

    void Awake()
    {
        shooting = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooting>();
        shootBullet = GameObject.Find("player").GetComponent<ShootBullet>();
        Destroy(gameObject, lifetime);
    }
    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position , shooting.enemyPosition , shooting.bulletSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {   
        Debug.Log("collision works");

        if ( other.gameObject.CompareTag("Enemy") )
        {
            Debug.Log("collision works");
            Destroy(other.gameObject);
            //shooting.numberOfKills += 1;
            shootBullet.NumberOfKills += 1;
            Destroy(gameObject);
            
        }

        

    }
}
