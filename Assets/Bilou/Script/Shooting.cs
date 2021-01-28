using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    
RaycastHit hit;
public GameObject Bullet;

public Transform Canon;

public Vector3 enemyPosition;
public float bulletSpeed;
void Update()
{        
    if (Input.GetMouseButtonDown(1))
    {
        if ( Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition) , out hit, Mathf.Infinity))
        {
            if ( hit.transform.gameObject.tag == "Enemy" )
            {
                enemyPosition = hit.transform.position;
                Shoot();
                Debug.Log("tst");
            }
        }
    }

    
}

void Shoot()
{
    

    Instantiate(Bullet , Canon.position, Canon.rotation);
    //bulletObj.transform.position = Vector3.Lerp(bulletObj.transform.position , enemyPosition , bulletSpeed);
    //bulletObj.transform.LookAt( enemyPosition );
    //bulletObj.transform.position = Vector3.MoveTowards ( Canon.position , enemyPosition , bulletSpeed * Time.deltaTime );
    //bulletObj.GetComponent<Rigidbody>().AddRelativeForce(bulletSpeed , 0 , 0);
    //Bullet.transform.position = Vector3.MoveTowards(Bullet.transform.position , enemyPosition , bulletSpeed * Time.deltaTime);
}

}