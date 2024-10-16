using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]private float maxHealth = 100f;
    private float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullethit")
        {
            float damage = other.gameObject.GetComponent<Bullet>().damage;
            Console.WriteLine("Hit");
            TakeDamage(damage);
        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
