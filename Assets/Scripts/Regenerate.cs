using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regenerate : MonoBehaviour
{
    public Player_Dodge_Hit_Die healthbar;
    public AudioSource audio;
    public HealthBar health;
    void OnTriggerEnter(Collider other)
    {
        //collectSound.Play();
        if (other.gameObject.tag == "Player")
        {
            audio.Play();
            healthbar.currentHealth = healthbar.maxHealth;
            health.SetHealth(healthbar.currentHealth);
            Destroy(gameObject);
        }

    }
}
