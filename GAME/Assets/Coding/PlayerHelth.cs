using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHelth : MonoBehaviour
{
    public int helth;
    public int BulletDamage;
    public int currentHealth;
    public int maxHealth;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet")
        {
            helth = helth - BulletDamage;
            Debug.Log(helth);
            currentHealth -= BulletDamage;
        }

        if (helth <= 0)
        {
            Destroy(gameObject, 0.2f);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
