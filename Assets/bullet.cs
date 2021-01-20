using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    private Shooting shooting;

    void Awake()
    {
        shooting = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooting>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position , shooting.enemyPosition , shooting.bulletSpeed * Time.deltaTime);
    }

    void OnCollisionEnter ( Collision other )
    {

        Destroy(gameObject);

    }
}
