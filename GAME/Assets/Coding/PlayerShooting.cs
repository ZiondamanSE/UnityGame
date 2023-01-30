using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    public float FireRate = 3;
    public float countdown = 3; 


    // Update is called once per frame
    void Update ()
    {

        if(Input.GetButton("Fire1")) 
        {
            countdown -= Time.deltaTime;

            if (countdown <= 0)
            {
                countdown = FireRate;
                Debug.Log("Next Shoot");
                Shoot();
            }
        }
    }

    void Shoot()
    {
        GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
