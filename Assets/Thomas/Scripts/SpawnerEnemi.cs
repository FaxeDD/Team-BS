using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemi : MonoBehaviour
{
    public Transform Spawner;
    public GameObject theEnemi;
    public int EnemiCount;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
       while (EnemiCount <10)
       {
        Instantiate(theEnemi, Spawner.position, Spawner.rotation);
       yield return new WaitForSeconds(0.1f);
       EnemiCount +=1;
       }
    }
}
