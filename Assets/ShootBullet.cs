using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    public int NumberOfKills = 0;

    //public ParticleSystem playerShoot;
    public AudioSource shootSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shootSound.Play();
            Shoot();

            if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        }
    }

    void Shoot()
    {
        //Instantiate(playerShoot , firepoint.position , firepoint.rotation );
       GameObject bullet = Instantiate(bulletPrefab,firepoint.position,firepoint.rotation);
       Rigidbody rb = bullet.GetComponent<Rigidbody>();
       rb.AddForce(firepoint.up * bulletForce, ForceMode.Impulse);
    }
}
