using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour {

    public float timeBetweenAttacks = 0.2f;
    public int attackDamage = 10;

    GameObject gnome;
    GnomeHealth enemyHealth;
    bool playerInRange;
    float timer;


    void Awake()
    {
        gnome = GameObject.FindGameObjectWithTag("Gnome");
        enemyHealth = GetComponent<GnomeHealth>();
        //anim = GetComponent<Animator>();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == gnome)
        {
            playerInRange = true;
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == gnome)
        {
            playerInRange = false;
        }
    }


    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
        {
            Attack();
        }

    //    if (enemyHealth.currentHealth <= 0)
    //    {
    //        anim.SetTrigger("PlayerDead");
    //    }
    }


    void Attack()
    {
        timer = 0f;

        if (enemyHealth.currentHealth > 0)
        {
            enemyHealth.TakeDamage(attackDamage);
        }
    }
}
