using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 1;
    private int Count;

    public Enemy listAccess = new Enemy();

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
            listAccess.Count--;
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
