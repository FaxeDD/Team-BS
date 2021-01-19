using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    
RaycastHit hit;
public GameObject Bullet;

public Transform Canon;
void Update()
{        
    if (Input.GetMouseButtonDown(1))
    {
        if ( Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition) , out hit, Mathf.Infinity))
        {
            if ( hit.transform.gameObject.tag == "Enemy" )
            {
                Shoot();
                Debug.Log("tst");
            }
        }
    }
}

void Shoot()
{
    //GameObject bulletObj = Instantiate(Bullet , Canon.position, Canon.rotation);
}

}