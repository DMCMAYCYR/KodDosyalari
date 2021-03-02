using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{

    int health=10;
    Rigidbody2D rb;
    public int Guc;
    public Vector3 moveDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Damage(int damage)
    {

        //rb.AddForce(-transform.right * Guc,ForceMode2D.Impulse);
        health -= damage;
        if (health<=0)
        {
            Die();
        }
    }
    public void Fırlat(Vector3 nab)
    {
        Debug.Log("ÇAlıştı");
        rb.AddForce(nab.normalized*Guc);
    }


    void Die()
    {
        Destroy(gameObject, 1);
    }
}
