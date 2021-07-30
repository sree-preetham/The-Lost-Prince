using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    //public AudioSource collectSound;
    public AudioSource sound;
    void OnTriggerEnter(Collider other)
    {
        //collectSound.Play();
        sound.Play();
        Score_card. score += 50;
        Destroy(gameObject);
    }
}
