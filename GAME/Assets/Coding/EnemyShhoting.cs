using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShhoting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform Target;
    public Transform firePoint;

    public float bulletForce = 20f;
    public float distanceToShoot = 2f;
    public float distanceToStop = 3f;

    public float fireRate;
    private float timeToFire;



    // Start is called before the first frame update
    void Start()
    {
        timeToFire = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(Target.position, transform.position) >= distanceToStop)
        {

        }
        else if (Vector2.Distance(Target.position, transform.position) <= distanceToStop)
        {
            Shoot();
        }
    }
    void Shoot() 
    {
        if (timeToFire <= 0)
        {
            GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
            Debug.Log("Shooting");
            timeToFire = fireRate;
        }
        else
        {
            timeToFire -= Time.deltaTime;
        }
    }
}
