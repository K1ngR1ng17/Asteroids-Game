using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public int damage = 1;
    public float fireForce = 5f;
    public float lifeTime;
    public Rigidbody2D rb;

    void Start()
    {
        Destroy(gameObject, lifeTime);
        rb.velocity = transform.up * fireForce;
    }


    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
