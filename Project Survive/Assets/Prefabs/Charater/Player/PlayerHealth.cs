using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health = 120f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        GetComponent<DisplayDamge>().ShowDamageImpact();

        if (health <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
