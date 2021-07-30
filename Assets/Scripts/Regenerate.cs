using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regenerate : MonoBehaviour
{
    public Player_Dodge_Hit_Die healthbar;
    public HealthBar health;
    void OnTriggerEnter(Collider other)
    {
        //collectSound.Play();
        if (other.gameObject.tag == "Player")
        {
            healthbar.currentHealth = healthbar.maxHealth;
            health.SetHealth(healthbar.currentHealth);
            Destroy(gameObject);
        }

    }
}
