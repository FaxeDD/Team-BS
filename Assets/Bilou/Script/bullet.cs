using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float lifetime = 2.0f;

    void Awake()
    {
        Destroy(gameObject, lifetime);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
        Destroy(this.gameObject);
        if(other.gameObject.CompareTag("Enemy")) 
        {
            Destroy (other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
