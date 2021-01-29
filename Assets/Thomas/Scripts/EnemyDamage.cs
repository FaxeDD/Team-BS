using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    public AudioSource playerTouched;

    private ClickToMove click;

    // Start is called before the first frame update
    void Start()
    {
        playerTouched = GameObject.Find("playerTouched").GetComponent<AudioSource>();
        click = GameObject.Find("player").GetComponent<ClickToMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) 
        {
            click.alphaLevel = 1f;
            playerTouched.Play();
            //Destroy (other.gameObject);
        }
    }
}
