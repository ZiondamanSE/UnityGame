using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHelth : MonoBehaviour
{
    public float helth;
    public float BulletDamage;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            helth = helth - BulletDamage;
            Debug.Log(helth);

        }

        if (helth <= 0)
        {
            Destroy(gameObject, 0.2f);
        }
    }
}
